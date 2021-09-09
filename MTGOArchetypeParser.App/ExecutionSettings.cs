using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.App
{
    class ExecutionSettings
    {
        private readonly float DefaultMinOthersPercent = 2.0f;

        public ExecutionOutput Output { get; set; }
        public ExecutionAction Action { get; set; }
        public string Format { get; set; }
        public string ReferenceFormat { get; set; }
        public string Meta { get; set; }
        public string MetaWeek { get; set; }
        public string[] Filter { get; set; }
        public string[] Exclude { get; set; }
        public string Archetype { get; set; }
        public string[] Card { get; set; }
        public string[] ExcludeCard { get; set; }
        public bool MetaBreakdown { get; set; }
        public bool MetaBreakdownShowCount { get; set; }
        public bool IncludeDecklists { get; set; }
        public string[] TournamentFolder { get; set; }
        public string FormatDataFolder { get; set; }
        public string OutputFile { get; set; }
        public int MaxDecksPerEvent { get; set; }
        public float MinOthersPercent { get; set; }

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
            this.MinOthersPercent = DefaultMinOthersPercent;

            string formatArgument = GetArgument(args, nameof(Format)).FirstOrDefault();
            string referenceFormatArgument = GetArgument(args, nameof(ReferenceFormat)).FirstOrDefault();
            string metaArgument = GetArgument(args, nameof(Meta)).FirstOrDefault();
            string metaWeekArgument = GetArgument(args, nameof(MetaWeek)).FirstOrDefault();
            string[] filterArgument = GetArgument(args, nameof(Filter));
            string[] excludeArgument = GetArgument(args, nameof(Exclude));
            string archetypeArgument = GetArgument(args, nameof(Archetype)).FirstOrDefault();
            string[] cardArgument = GetArgument(args, nameof(Card));
            string[] excludeCardArgument = GetArgument(args, nameof(ExcludeCard));
            string breakdownArgument = GetArgument(args, nameof(MetaBreakdown)).FirstOrDefault();
            string breakdownCountArgument = GetArgument(args, nameof(MetaBreakdownShowCount)).FirstOrDefault();
            string decklistsArgument = GetArgument(args, nameof(IncludeDecklists)).FirstOrDefault();
            string[] cacheFoldersArgument = GetArgument(args, nameof(TournamentFolder));
            string dataFolderArgument = GetArgument(args, nameof(FormatDataFolder)).FirstOrDefault();
            string outputFileArgument = GetArgument(args, nameof(OutputFile)).FirstOrDefault();
            string maxDecksPerEventArgument = GetArgument(args, nameof(MaxDecksPerEvent)).FirstOrDefault();
            string minOthersPercentArgument = GetArgument(args, nameof(MinOthersPercent)).FirstOrDefault();

            if (formatArgument != null) this.Format = formatArgument;
            if (referenceFormatArgument != null) this.ReferenceFormat = referenceFormatArgument;
            if (metaArgument != null) this.Meta = metaArgument;
            if (metaWeekArgument != null) this.MetaWeek = metaWeekArgument;
            if (filterArgument.Length > 0) this.Filter = filterArgument;
            if (excludeArgument.Length > 0) this.Exclude = excludeArgument;
            if (archetypeArgument != null) this.Archetype = archetypeArgument;
            if (cardArgument.Length > 0) this.Card = cardArgument;
            if (excludeCardArgument.Length > 0) this.ExcludeCard = excludeCardArgument;
            if (breakdownArgument != null) this.MetaBreakdown = (breakdownArgument.ToLowerInvariant() == "true");
            if (breakdownCountArgument != null) this.MetaBreakdownShowCount = (breakdownCountArgument.ToLowerInvariant() == "true");
            if (decklistsArgument != null) this.IncludeDecklists = (decklistsArgument.ToLowerInvariant() == "true");
            if (cacheFoldersArgument.Length > 0) this.TournamentFolder = cacheFoldersArgument;
            if (dataFolderArgument != null) this.FormatDataFolder = dataFolderArgument;
            if (outputFileArgument != null) this.OutputFile = outputFileArgument;
            if (maxDecksPerEventArgument != null && Int32.TryParse(maxDecksPerEventArgument, out int parsedMaxDecks)) this.MaxDecksPerEvent = parsedMaxDecks;
            if (minOthersPercentArgument != null && float.TryParse(minOthersPercentArgument, NumberStyles.Any, CultureInfo.InvariantCulture, out float parsedMinOthers)) this.MinOthersPercent = parsedMinOthers;

            ExecutionAction actionArgument = ExecutionAction.NotSpecified;
            if (args.Length > 1) Enum.TryParse<ExecutionAction>(args[1], true, out actionArgument);
            if (actionArgument != ExecutionAction.NotSpecified) this.Action = actionArgument;

            ExecutionOutput outputArgument = ExecutionOutput.NotSpecified;
            if (args.Length > 0) Enum.TryParse<ExecutionOutput>(args[0], true, out outputArgument);
            if (outputArgument != ExecutionOutput.NotSpecified) this.Output = outputArgument;

            // Required setting for these features to work
            if ((this.Card != null && this.Card.Length > 0) || (this.ExcludeCard != null && this.ExcludeCard.Length > 0)) this.IncludeDecklists = true;
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
            if (this.Filter != null && this.Filter.Length > 0) this.Filter.ToList().ForEach(f => Console.WriteLine($"* {nameof(this.Filter)}: {f}"));
            if (this.Exclude != null && this.Exclude.Length > 0) this.Exclude.ToList().ForEach(e => Console.WriteLine($"* {nameof(this.Exclude)}: {e}"));
            if (!String.IsNullOrEmpty(this.Archetype)) Console.WriteLine($"* {nameof(this.Archetype)}: {this.Archetype.ToString()}");
            if (this.Card != null && this.Card.Length > 0) this.Card.ToList().ForEach(c => Console.WriteLine($"* {nameof(this.Card)}: {c}"));
            if (this.ExcludeCard != null && this.ExcludeCard.Length > 0) this.ExcludeCard.ToList().ForEach(c => Console.WriteLine($"* {nameof(this.ExcludeCard)}: {c}"));
            Console.WriteLine($"* {nameof(this.MetaBreakdown)}: {this.MetaBreakdown.ToString()}");
            Console.WriteLine($"* {nameof(this.MetaBreakdownShowCount)}: {this.MetaBreakdownShowCount.ToString()}");
            Console.WriteLine($"* {nameof(this.IncludeDecklists)}: {this.IncludeDecklists.ToString()}");
            if (this.MaxDecksPerEvent > 0) Console.WriteLine($"* {nameof(this.MaxDecksPerEvent)}: {this.MaxDecksPerEvent.ToString()}");
            if (this.MinOthersPercent != DefaultMinOthersPercent) Console.WriteLine($"* {nameof(this.MinOthersPercent)}: {this.MinOthersPercent.ToString()}");
            if (this.TournamentFolder != null && this.TournamentFolder.Length > 0) this.TournamentFolder.ToList().ForEach(f => Console.WriteLine($"* {nameof(this.TournamentFolder)}: {f}"));
            if (!String.IsNullOrEmpty(this.FormatDataFolder)) Console.WriteLine($"* {nameof(this.FormatDataFolder)}: {this.FormatDataFolder.ToString()}");
            if (!String.IsNullOrEmpty(this.OutputFile)) Console.WriteLine($"* {nameof(this.OutputFile)}: {this.OutputFile.ToString()}");
        }
    }

    public enum ExecutionOutput
    {
        NotSpecified,
        Console,
        Csv,
        Json
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
