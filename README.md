# LocalizationScriptUnity
Ready and simple C# script to read a Json file(s) for localization


## LocalizeObserverSingelton

-Place this script on your GameManager ( GameObject )

### Features

- (Language in Editor)
	Use for select which language do you want start from. ( base on list of json file(s) index )
- (jsonFiles in Editor)
	Insert json file(s) here

	format for json ( example )
```json
[
  {
    "key": "home",
    "value": "home"
  },
  {
    "key": "back",
    "value": "back"
  },
  {
    "key": "change_language",
    "value": "change language"
  }
]
```
	for key, the value must be in lowercase.

	you can check in json folder for example
	
	

## LocalizeObservable

	Place this script on your GameObject that you want to localize.

	You dont need to set text on the Text Component.

### Features

- Auto set text to value in json file

- (Key in Editor)
	Input your key value here from json file.

## LocalizeButton

	Place this script on your Button which will trigger change language when clicked on runtime.

