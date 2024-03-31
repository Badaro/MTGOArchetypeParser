using MTGOArchetypeParser.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MTGOArchetypeParser.App
{
    public class ExecutionSettings
    {
        private readonly float DefaultMinOthersPercent = 2.0f;
        internal readonly string OthersKey = "Others";


        public ExecutionOutput Output { get; set; }
        public ExecutionAction Action { get; set; }
        public string Format { get; set; }
        public string ReferenceFormat { get; set; }
        public string Meta { get; set; }
        public string MetaWeek { get; set; }
        public string[] Filter { get; set; }
        public string[] FolderFilter { get; set; }
        public string[] Exclude { get; set; }
        public string Archetype { get; set; }
        public string Player { get; set; }
        public string[] Card { get; set; }
        public string[] ExcludeCard { get; set; }
        public string Color { get; set; }
        public bool MetaBreakdown { get; set; }
        public bool MetaBreakdownShowCount { get; set; }
        public bool CardBreakdown { get; set; }
        public bool WinrateBreakdown { get; set; }
        public bool IncludeDecklists { get; set; }
        public bool IncludeMatchups { get; set; }
        public string[] TournamentFolder { get; set; }
        public string FormatDataFolder { get; set; }
        public string OutputFile { get; set; }
        public int MaxDecksPerEvent { get; set; }
        public float MinOthersPercent { get; set; }
        public bool ShowColors { get; set; }
        public ConflictSolvingMode ConflictSolvingMode { get; set; }
        public DateTime? StartDate { get; set; }
        public string MatchupsFor { get; set; }

        public static ExecutionSettings FromJsonFile(string jsonFile)
        {
            if (File.Exists(jsonFile))
            {
                try
                {
                    return JsonConvert.DeserializeObject<ExecutionSettings>(File.ReadAllText(jsonFile));
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error loading settings file: {ex.Message}");
                }
            }

            return new ExecutionSettings();
        }

        public void ApplyOverrides(string[] args)
        {
            // Cleaning up of quotes in parameters, also allows : as an alternative for = for parameter splitting
            args = args.Select(a =>
            {
                if (!a.Contains("=") && a.Contains(":")) a = ReplaceFirst(a, ":", "=");
                if (a.StartsWith("\"")) a = a.TrimStart('"').TrimEnd('"');
                return a;
            }).ToArray();

            this.MinOthersPercent = DefaultMinOthersPercent;

            string formatArgument = GetArgument(args, nameof(Format)).FirstOrDefault();
            string referenceFormatArgument = GetArgument(args, nameof(ReferenceFormat)).FirstOrDefault();
            string metaArgument = GetArgument(args, nameof(Meta)).FirstOrDefault();
            string metaWeekArgument = GetArgument(args, nameof(MetaWeek)).FirstOrDefault();
            string[] filterArgument = GetArgument(args, nameof(Filter));
            string[] folderFilterArgument = GetArgument(args, nameof(FolderFilter));
            string[] excludeArgument = GetArgument(args, nameof(Exclude));
            string archetypeArgument = GetArgument(args, nameof(Archetype)).FirstOrDefault();
            string playerArgument = GetArgument(args, nameof(Player)).FirstOrDefault();
            string colorArgument = GetArgument(args, nameof(Color)).FirstOrDefault();
            string[] cardArgument = GetArgument(args, nameof(Card));
            string[] excludeCardArgument = GetArgument(args, nameof(ExcludeCard));
            string breakdownArgument = GetArgument(args, nameof(MetaBreakdown)).FirstOrDefault();
            string breakdownCountArgument = GetArgument(args, nameof(MetaBreakdownShowCount)).FirstOrDefault();
            string cardBreakdownArgument = GetArgument(args, nameof(CardBreakdown)).FirstOrDefault();
            string winrateBreakdownArgument = GetArgument(args, nameof(WinrateBreakdown)).FirstOrDefault();
            string decklistsArgument = GetArgument(args, nameof(IncludeDecklists)).FirstOrDefault();
            string matchupsArgument = GetArgument(args, nameof(IncludeMatchups)).FirstOrDefault();
            string[] cacheFoldersArgument = GetArgument(args, nameof(TournamentFolder));
            string dataFolderArgument = GetArgument(args, nameof(FormatDataFolder)).FirstOrDefault();
            string outputFileArgument = GetArgument(args, nameof(OutputFile)).FirstOrDefault();
            string maxDecksPerEventArgument = GetArgument(args, nameof(MaxDecksPerEvent)).FirstOrDefault();
            string minOthersPercentArgument = GetArgument(args, nameof(MinOthersPercent)).FirstOrDefault();
            string showColorsArgument = GetArgument(args, nameof(ShowColors)).FirstOrDefault();
            string conflictArgument = GetArgument(args, nameof(ConflictSolvingMode)).FirstOrDefault();
            string startDateArgument = GetArgument(args, nameof(StartDate)).FirstOrDefault();
            string matchupsForArgument = GetArgument(args, nameof(MatchupsFor)).FirstOrDefault();

            if (formatArgument != null) this.Format = formatArgument;
            if (referenceFormatArgument != null) this.ReferenceFormat = referenceFormatArgument;
            if (metaArgument != null) this.Meta = metaArgument;
            if (metaWeekArgument != null) this.MetaWeek = metaWeekArgument;
            if (filterArgument.Length > 0) this.Filter = filterArgument;
            if (folderFilterArgument.Length > 0) this.FolderFilter = folderFilterArgument;
            if (excludeArgument.Length > 0) this.Exclude = excludeArgument;
            if (archetypeArgument != null) this.Archetype = archetypeArgument;
            if (playerArgument != null) this.Player = playerArgument;
            if (colorArgument != null) this.Color = NormalizeColor(colorArgument);
            if (cardArgument.Length > 0) this.Card = cardArgument;
            if (excludeCardArgument.Length > 0) this.ExcludeCard = excludeCardArgument;
            if (breakdownArgument != null) this.MetaBreakdown = (breakdownArgument.ToLowerInvariant() == "true");
            if (breakdownCountArgument != null) this.MetaBreakdownShowCount = (breakdownCountArgument.ToLowerInvariant() == "true");
            if (cardBreakdownArgument != null) this.CardBreakdown = (cardBreakdownArgument.ToLowerInvariant() == "true");
            if (winrateBreakdownArgument != null) this.WinrateBreakdown = (winrateBreakdownArgument.ToLowerInvariant() == "true");
            if (decklistsArgument != null) this.IncludeDecklists = (decklistsArgument.ToLowerInvariant() == "true");
            if (matchupsArgument != null) this.IncludeMatchups = (matchupsArgument.ToLowerInvariant() == "true");
            if (cacheFoldersArgument.Length > 0) this.TournamentFolder = cacheFoldersArgument;
            if (dataFolderArgument != null) this.FormatDataFolder = dataFolderArgument;
            if (outputFileArgument != null) this.OutputFile = outputFileArgument;
            if (maxDecksPerEventArgument != null && Int32.TryParse(maxDecksPerEventArgument, out int parsedMaxDecks)) this.MaxDecksPerEvent = parsedMaxDecks;
            if (minOthersPercentArgument != null && float.TryParse(minOthersPercentArgument, NumberStyles.Any, CultureInfo.InvariantCulture, out float parsedMinOthers)) this.MinOthersPercent = parsedMinOthers;
            if (showColorsArgument != null) this.ShowColors = (showColorsArgument.ToLowerInvariant() == "true");
            if (matchupsForArgument != null) this.MatchupsFor = matchupsForArgument;

            if (startDateArgument != null)
            {
                if (DateTime.TryParseExact(startDateArgument, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out DateTime parsedStartDate))
                {
                    this.StartDate = parsedStartDate.ToUniversalTime();
                }
            }

            ExecutionAction actionArgument = ExecutionAction.NotSpecified;
            if (args.Length > 1) Enum.TryParse<ExecutionAction>(args[1], true, out actionArgument);
            if (actionArgument != ExecutionAction.NotSpecified) this.Action = actionArgument;

            ExecutionOutput outputArgument = ExecutionOutput.NotSpecified;
            if (args.Length > 0) Enum.TryParse<ExecutionOutput>(args[0], true, out outputArgument);
            if (outputArgument != ExecutionOutput.NotSpecified) this.Output = outputArgument;

            ConflictSolvingMode conflictParsedArgument = ConflictSolvingMode.None;
            if (conflictArgument != null)
            {
                if (Enum.TryParse<ConflictSolvingMode>(conflictArgument, true, out conflictParsedArgument))
                {
                    this.ConflictSolvingMode = conflictParsedArgument;
                }
            }

            // Required setting for these features to work
            if ((this.Card != null && this.Card.Length > 0) || (this.ExcludeCard != null && this.ExcludeCard.Length > 0) || this.CardBreakdown) this.IncludeDecklists = true;
            if (this.MatchupsFor != null || this.WinrateBreakdown) this.IncludeMatchups = true;

            // Folder normalization
            if (this.OutputFile != null) this.OutputFile = NormalizePath(this.OutputFile);
            if (this.FormatDataFolder != null) this.FormatDataFolder = NormalizePath(this.FormatDataFolder);
            if (this.TournamentFolder != null) this.TournamentFolder = this.TournamentFolder.Select(s => NormalizePath(s)).ToArray();
        }

        string[] GetArgument(string[] args, string settingName)
        {
            List<string> result = new List<string>();
            foreach (var setting in args.Where(a => a.ToLower().StartsWith($"{settingName.ToLower()}=")).ToArray())
            {
                string[] segments = setting.Split("=");
                if (segments.Length == 2) result.Add(segments[1]);
            }
            return result.ToArray();
        }

        public void Validate()
        {
            if (this.Action == ExecutionAction.NotSpecified) throw new ValidationException("Action invalid or not specified");
            if (this.Output == ExecutionOutput.NotSpecified) throw new ValidationException("Output invalid or not specified");
            if (String.IsNullOrEmpty(this.Format)) throw new ValidationException("Format not specified");

            if (String.IsNullOrEmpty(this.FormatDataFolder)) throw new ValidationException("Format data folder not specified");
            if (!Directory.Exists(this.FormatDataFolder)) throw new ValidationException("Format data folder does not exist");

            if (this.TournamentFolder == null || this.TournamentFolder.Length == 0) throw new Exception("Tournament folder folder not specified");
            foreach (string tournamentFolder in this.TournamentFolder)
            {
                if (!Directory.Exists(tournamentFolder)) throw new ValidationException("Tournament folder does not exist");
            }

            if (!String.IsNullOrEmpty(this.MetaWeek) && this.MetaWeek.ToLower() != "current")
            {
                if (!Int32.TryParse(this.MetaWeek, out int parsed)) throw new ValidationException("Meta week must be 'current' or a number");
            }
        }

        public void Print()
        {
            Console.WriteLine("Settings in use for this execution:");

            if (this.Output != ExecutionOutput.NotSpecified) Console.WriteLine($"* {nameof(this.Output)}: {this.Output.ToString()}");
            if (this.Action != ExecutionAction.NotSpecified) Console.WriteLine($"* {nameof(this.Action)}: {this.Action.ToString()}");
            if (!String.IsNullOrEmpty(this.Format)) Console.WriteLine($"* {nameof(this.Format)}: {this.Format.ToString()}");
            if (!String.IsNullOrEmpty(this.ReferenceFormat)) Console.WriteLine($"* {nameof(this.ReferenceFormat)}: {this.ReferenceFormat.ToString()}");
            if (!String.IsNullOrEmpty(this.Meta)) Console.WriteLine($"* {nameof(this.Meta)}: {this.Meta.ToString()}");
            if (!String.IsNullOrEmpty(this.MetaWeek)) Console.WriteLine($"* {nameof(this.MetaWeek)}: {this.MetaWeek.ToString()}");
            if (this.StartDate != null) Console.WriteLine($"* {nameof(this.StartDate)}: {this.StartDate.Value.ToString("yyyy-MM-dd")}");
            if (this.Filter != null && this.Filter.Length > 0) this.Filter.ToList().ForEach(f => Console.WriteLine($"* {nameof(this.Filter)}: {f}"));
            if (this.FolderFilter != null && this.FolderFilter.Length > 0) this.FolderFilter.ToList().ForEach(f => Console.WriteLine($"* {nameof(this.FolderFilter)}: {f}"));
            if (this.Exclude != null && this.Exclude.Length > 0) this.Exclude.ToList().ForEach(e => Console.WriteLine($"* {nameof(this.Exclude)}: {e}"));
            if (!String.IsNullOrEmpty(this.Archetype)) Console.WriteLine($"* {nameof(this.Archetype)}: {this.Archetype.ToString()}");
            if (!String.IsNullOrEmpty(this.Player)) Console.WriteLine($"* {nameof(this.Player)}: {this.Player.ToString()}");
            if (!String.IsNullOrEmpty(this.Color)) Console.WriteLine($"* {nameof(this.Color)}: {this.Color.ToString()}");
            if (this.Card != null && this.Card.Length > 0) this.Card.ToList().ForEach(c => Console.WriteLine($"* {nameof(this.Card)}: {c}"));
            if (this.ExcludeCard != null && this.ExcludeCard.Length > 0) this.ExcludeCard.ToList().ForEach(c => Console.WriteLine($"* {nameof(this.ExcludeCard)}: {c}"));
            Console.WriteLine($"* {nameof(this.MetaBreakdown)}: {this.MetaBreakdown.ToString()}");
            Console.WriteLine($"* {nameof(this.MetaBreakdownShowCount)}: {this.MetaBreakdownShowCount.ToString()}");
            Console.WriteLine($"* {nameof(this.CardBreakdown)}: {this.CardBreakdown.ToString()}");
            Console.WriteLine($"* {nameof(this.WinrateBreakdown)}: {this.WinrateBreakdown.ToString()}");
            Console.WriteLine($"* {nameof(this.IncludeDecklists)}: {this.IncludeDecklists.ToString()}");
            Console.WriteLine($"* {nameof(this.IncludeMatchups)}: {this.IncludeMatchups.ToString()}");
            if (this.MaxDecksPerEvent > 0) Console.WriteLine($"* {nameof(this.MaxDecksPerEvent)}: {this.MaxDecksPerEvent.ToString()}");
            if (this.MinOthersPercent != DefaultMinOthersPercent) Console.WriteLine($"* {nameof(this.MinOthersPercent)}: {this.MinOthersPercent.ToString()}");
            if (this.TournamentFolder != null && this.TournamentFolder.Length > 0) this.TournamentFolder.ToList().ForEach(f => Console.WriteLine($"* {nameof(this.TournamentFolder)}: {f}"));
            if (!String.IsNullOrEmpty(this.FormatDataFolder)) Console.WriteLine($"* {nameof(this.FormatDataFolder)}: {this.FormatDataFolder.ToString()}");
            if (!String.IsNullOrEmpty(this.OutputFile)) Console.WriteLine($"* {nameof(this.OutputFile)}: {this.OutputFile.ToString()}");
            Console.WriteLine($"* {nameof(this.ShowColors)}: {this.ShowColors.ToString()}");
            if (this.ConflictSolvingMode != ConflictSolvingMode.None) Console.WriteLine($"* {nameof(this.ConflictSolvingMode)}: {this.ConflictSolvingMode.ToString()}");
            if (!String.IsNullOrEmpty(this.MatchupsFor)) Console.WriteLine($"* {nameof(this.MatchupsFor)}: {this.MatchupsFor.ToString()}");
        }

        public string NormalizeColor(string color)
        {
            string normalizedColor = "";
            if (color.Contains("W", StringComparison.InvariantCultureIgnoreCase)) normalizedColor += "W";
            if (color.Contains("U", StringComparison.InvariantCultureIgnoreCase)) normalizedColor += "U";
            if (color.Contains("B", StringComparison.InvariantCultureIgnoreCase)) normalizedColor += "B";
            if (color.Contains("R", StringComparison.InvariantCultureIgnoreCase)) normalizedColor += "R";
            if (color.Contains("G", StringComparison.InvariantCultureIgnoreCase)) normalizedColor += "G";
            return normalizedColor;
        }

        public string NormalizePath(string path)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return path.Replace("/", "\\");
            }
            else
            {
                return path.Replace("\\", "/");
            }
        }

        private string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }

    public enum ExecutionOutput
    {
        NotSpecified,
        Console,
        Csv,
        Json,
        Reddit
    }

    public enum ExecutionAction
    {
        NotSpecified,
        Detect,
        Compare
    }

    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }
}
