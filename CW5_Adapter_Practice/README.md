# CW5 Adapter Practice # 

## Description ##
- The project fulfills the instructions of an assignment focusing on introducing the Adapter structural design pattern.

## Project Details: ##
- Contains two interfaces: IBear and IToyBear. 
- Contains two concrete classes: Grizzly and TeddyBear.
- Contains one adapter: BearAdapter (which inherits from IToyBear interface and takes an object of IBear interface type and uses it within the concrete Adapter)
-- Basically, BearAdapter allows an object of IBear interface type to be used within an object of IToyBear interface type. 

## To Use ## 
- From within VS2022, run the CW5_Adapter_Practice startup project. The methods of the various present classes within the program will be run, writing various outputs to the console.