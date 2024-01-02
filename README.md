# MTGOArchetypeParser

Rules-based engine to detect archetypes from MTGO decklists.

## Getting started

* Install .Net Runtime: https://dotnet.microsoft.com/en-us/download/dotnet/8.0
* Download the latest release of MTGOArchetypeParser: https://github.com/Badaro/MTGOArchetypeParser/releases
* Clone the tournament results: https://github.com/Badaro/MTGODecklistCache
* Clone the archetype definitions: https://github.com/Badaro/MTGOFormatData

Extract the ZIP from MTGOArchetypeParser, and put the tournaments and archetype definitions in the same folder. You should end up with a structure like this:

```
MTGOArchetypeParser
MTGOArchetypeParser/MTGODecklistCache
MTGOArchetypeParser/MTGOFormatData
```
Once you do that, open a console prompt on the MTGOArchetypeParser folder and run this:

Windows:
```MTGOArchetypeParser.App.exe console detect format=Modern filter=modern-preliminary-2021-01-21```

Linux: 
```dotnet MTGOArchetypeParser.App.dll console detect format=Modern filter=modern-preliminary-2021-01-21```

If you did things correctly you should see a message displaying the results of the detection for that Modern event:

```
Detection results:
* modern-preliminary-2021-01-2112252742 -> 4-0 yamakiller (Burn)
* modern-preliminary-2021-01-2112252742 -> 4-0 Simpleliquid (Spirits)
* modern-preliminary-2021-01-2112252742 -> 3-1 cntrlfreak (Shadow Prowess)
* modern-preliminary-2021-01-2112252742 -> 3-1 ElectricBob (Rakdos Midrange)
* modern-preliminary-2021-01-2112252742 -> 3-1 cariollins (Shadow Prowess)
* modern-preliminary-2021-01-2112252742 -> 3-1 HouseOfManaMTG (Amulet Titan)
* modern-preliminary-2021-01-2112252742 -> 3-1 aplapp (Heliod Combo)
* modern-preliminary-2021-01-2112252745 -> 4-0 kthanakit26 (Izzet Prowess)
* modern-preliminary-2021-01-2112252745 -> 3-1 SourceOdin (Heliod Combo)
* modern-preliminary-2021-01-2112252745 -> 2-1 Dean911 (Green Tron)
* modern-preliminary-2021-01-2112252745 -> 3-1 Rosencrantz_920 (Amulet Titan)
* modern-preliminary-2021-01-2112252745 -> 3-1 Rinko (Enduring Ideal)
* modern-preliminary-2021-01-2112252745 -> 3-1 errorman (Gyruda Reanimator)
```
If you got that, congratulations! You can now start playing with the archetypes. 

Remember to run a ```git pull``` on MTGODecklistCache and MTGOFormatData periodically to get updated data.

**Check the MTGOFormatData repository for information on which formats are currently supported for detection.**

If you're interested in creating archetype definitions for other formats, please check the "Creating new archetype definitions" section at the end of this readme.

## Output options

The first argument of the tool is how to display the output. There's four options at the moment:

* console
* csv
* json
* reddit

The first one will display the results on the console, while the second one will generate a CSV file in the same folder as the application with the name ```mtgo_data_yyyy_mm_dd.csv```. The third one will output a JSON file with the name ```mtgo_data_yyyy_mm_dd.json```. Finally, reddit will output to the console appropriately formatted reddit markup including a link to the deckist.

You can also specify the file name to be used with the ```outputfile``` parameter.

## Action options

The second argument of the tool is what it'll do. There's two options at the moment:

* detect
* compare

Detect will just display the results of the archetype detection, while compare will compare two sets of archetypes definitions and let you know what's changed. More details on that below.

## Format options

You need to always specify the format you're using to evaluate those decklists. This is done with the ```format=myformat``` parameter. 

If you're using the compare option, you also need to specify a second set of archetype definitions to use. The parameter for this is ```referenceformat=myotherformat``` parameter.

Notice that ```format=myformat``` does *not* filters for events with that format, it only specifies which format to use for detection. So in most scenarios you'll be combining it with a filter parameter, like this: ```format=myformat filter=myformat```

## Filtering options

There's a few ways to filter which events will included in the detection. Here's some of the most useful ones:

* ```meta=mymeta``` lets you filter to only include events in a specific meta.  You can also use ```meta=current``` to specify "most recent meta"
* ```metaweek=weeknumber``` lets you filter to only include events in a specific meta week. You can also use ```metaweek=current``` to specify "most recent meta week". This parameter will be ignored if meta is not set.
* ```startdate=yyyy-mm-dd``` lets you filter to only include events on or after a specific date. If this parameter is present ```meta``` and ```metaweek``` are ignored
* ```filter=text``` lets you filter to only include events that contain a certain text in the name or URL
* ```exclude=text```lets you filter to exclude events that contain a certain text in the name or URL
* ```archetype=text```lets you filter to only list decks of a specific archetype
* ```card=text```: Lets you filter to only list decks that contains a specific card, requires includedecklists=true
* ```excludecard=text```: Lets you filter to only list decks that do not contain a specific card, requires includedecklists=true

You can run the tool without any parameters to see a more complete list.

## meta breakdown

* ```metabreakdown=true``` will include a short meta breakdown summary at the end of the console output

## settings.json file

There's a ```settings.json``` file that you can use to set default settings so you don't have to type them all the time.

Let's say you're only looking at Modern events, and you're ignoring Leagues since they're not curated, you could set this in this file:

```   
  "Filter": [
    "Modern"
  ],
  "Exclude": [
    "League"
  ],
```

Be careful that settings in this file are only used if you don't specify the same settings in the command line. If you have the file above and use ```filter=preliminary``` in the command line the filter for Modern events above will *not* be applied. Either specify both using the JSON file, or both using the command line. 
## Creating new archetype definitions

If you're interested in adding more formats to this tool, or to improve the quality of the archetype definitions, please check the readme in the page below, which explains how the data structure works:

https://github.com/Badaro/MTGOFormatData

## Working with a new format

If you want to add a new format not present in the repository above, start by creating the minimum required files and folders, then go on writing the archetype definitions. 

This is a job that requires some patience - I recommend doing this event by event. Start with the most recent challenge or preliminary, write the rules for the #1 player, check if the detection is correct, then do it for the #2 player, and keep going. Once you're done, get the previous event and do the same thing.

The more archetypes you add, the easier it gets.

## Improving an existing format

If you want to improve a format already in the repository, I recommend you make a copy of the entire folder before making any changes.

Say you want to try your hand at improving the Modern definitions. Before starting, make a copy of the ```Modern``` folder and call it ```Modern-Old```, then start making your changes.

The reason for that is this will allow you to use the ```compare``` mode of the console tool to see if you're not breaking a lot of things with your changes. You can use ```compare format=Modern referenceformat=Modern-Old``` to see the exact impact of your changes.

## A word about Leagues

I personally recommend using ```exclude=Leagues``` when working on archetype definitions. Due to the way WOTC selects the 5-0 lists, they tend to have a lot of "weird" and "off-meta" lists.

As fun as it can be to tag those, they require a lot of effort for lists that often don't show up more than once or twice.
