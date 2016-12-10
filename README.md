# HoT
#Azure
- Zarejestrować urządzenie Device, do bazy.
- Sprawdzić czy jest podłączony Device
- Znaleść urządzenie po ID
- Otrzymać Sensory urządzenia po ID
- Wpisać Value do IDDevice/SensorName
- Otrzymać Value z IDDevice/SensorName

##Azure API

GET /api/devices/{userId}

GET /api/{deviceId}

GET /api/{deviceID}/{SensorName}

POST Value /api/{deviceId}/{SensorName}

#ESP
- Zczytać informacje o Device
- Podlączyć się do sieci WI-Fi
- Wysłać Device Info do Azure
- Otrzymać i zachować Device ID
- Przyjąć z Azure info IDDevice/SensorName/Value
- Przekazać Arduino info SensorName/Value
- Poprosić u Arduino info SensorName/Value
- Wyslać do Azure info SensorName/Value

#Arduino
- Zapakować i wysłać do ESP info o swoich urządzeniach
- Przyjąć info od ESP zeby zczytać Value of SensorName
- Wysłać do ESP SensorName/Value

#Xamarin
- Zrobić komunikację z Azure REST API
..- Otrzymać liste Podłączonych Devices
..- Otrzymać liste Sensors by IDDevice
..- Otrzymywać value z IDdevice/SensorName
..- Zapisać value z IDDevice/SensorName
- Zrobić UI zgodnie z tym jakie Sensors ma podłączony Device

| Operacja | ValueTypeName | Control |
|----------|---------------|---------|
|Read| Bool|Dioda czy coś co powie że sensor ON/OFF|
|Read|Double|Label|
|Write|Bool|ToggleButton|
|Write|Double|Textbox|
