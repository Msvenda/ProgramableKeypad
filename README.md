# Programable Keypad

This project uses a standard Arduino Uno flashed with the [Hoodloader 2](https://github.com/NicoHood/HoodLoader2 "Hoodloader 2") bootloader by NicoHood to create a fully programmable keypad. The keypad supports 4 programmable profiles as well as a static profile in which it works as a standard keypad. An OLED display is used to inform the user of the status of the keyboard as well as to allow lookup of key functions.

## Features
- 21 keys (6 rows, 4 columns)
	- 19 programmable keys
	- 2 designated function keys
- Software n-key rollover support
- Standard keypad functionality
- 4 programmable profiles
- Macro support
	- String
	- Modifier + String
	- Looping macro
- Function key support
- OLED display
	- Status display
	- Error display
	- Key lookup
- Windows app for re-programming of keypad

## Arduino wiring

It is assumed that the keypad is wired in a matrix configuration with 1 diode per key.

Pins 3-8 connected to the rows of the keyboard, while pins 8-12 are connected to the columns.

The oled screen is connected using an I2C connection. the SDA pin on the OLED screen is connected to the A04 pin on the arduino, while the SCL pin is connected to A05.
