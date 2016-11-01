# BitcoinGenie

A little funny software that helps with some of my tutorials I am creating.

## Articles:

CodeProject - [Create a Bitcoin transaction by hand](http://www.codeproject.com/Articles/1151054/Create-a-Bitcoin-transaction-by-hand)

## Download / Run

###Prerequisites

####Install the .NET Core SDK:

#####Windows

1. At the time of writing this is the most recent version: https://go.microsoft.com/fwlink/?LinkID=827524
2. But you can always find the most up-to-date one here: https://www.microsoft.com/net/core#windows

#####Ubuntu 16.04

1. At the time of writing this is how you install the most recent version:  
  `sudo sh -c 'echo "deb [arch=amd64] https://apt-mo.trafficmanager.net/repos/dotnet-release/ xenial main" > /etc/apt/sources.list.d/dotnetdev.list'`  
  `sudo apt-key adv --keyserver apt-mo.trafficmanager.net --recv-keys 417A0893`  
  `sudo apt-get update`  
  `sudo apt-get install dotnet-dev-1.0.0-preview2-003131`  

2. But you can always find the most up-to-date one here: https://www.microsoft.com/net/core#ubuntu

##### Everyone else

https://www.microsoft.com/net/core

### Download

Clone or download [this github repository](https://github.com/nopara73/BitcoinGenie/).

### Build  
  
1. Open a terminal/console window in BitcoinGenie/src/BitcoinGenie folder.  
2. Type:  
  `dotnet restore`  
  `dotnet build`
  
### Run the software:
So far you downloaded the .NET Core Framework, my project, restored its dependencies and built the software. An other way to put it: you installed it.  
  
To run the software:
  
1. Open a terminal/console window in BitcoinGenie/src/BitcoinGenie folder.
2. Type: `dotnet run`
  
## For developers
  
It is a .NET Core Console Application, so you will need:  
* .NET Core  
* (optional) Visual Studio: Build -> Run  
