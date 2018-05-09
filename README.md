# BitcoinGenie

A little funny software that helps with some of my tutorials I am creating.

## Articles:

CodeProject - [Create a Bitcoin transaction by hand](http://www.codeproject.com/Articles/1151054/Create-a-Bitcoin-transaction-by-hand)

## Download / Run

### Prerequisites

#### Install the .NET Core SDK:

##### Windows

1. At the time of writing this is the most recent version: https://go.microsoft.com/fwlink/?LinkID=827524
2. But you can always find the most up-to-date one here: https://www.microsoft.com/net/core#windows

##### Ubuntu

1. Register Microsoft signature key in order to verify the authenticity of the software that you need to download and install.

##### Ubuntu 16.04

`curl https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > microsoft.gpg`
`sudo mv microsoft.gpg /etc/apt/trusted.gpg.d/microsoft.gpg`
`sudo sh -c 'echo "deb [arch=amd64] https://packages.microsoft.com/repos/microsoft-ubuntu-xenial-prod xenial main" > /etc/apt/sources.list.d/dotnetdev.list'`

##### Ubuntu 17.10

`curl https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > microsoft.gpg`
`sudo mv microsoft.gpg /etc/apt/trusted.gpg.d/microsoft.gpg`
`sudo sh -c 'echo "deb [arch=amd64] https://packages.microsoft.com/repos/microsoft-ubuntu-artful-prod artful main" > /etc/apt/sources.list.d/dotnetdev.list'`

##### Ubuntu 16.04 / 17.10

`sudo apt-get install apt-transport-https`
`sudo apt-get update`
`sudo apt-get install dotnet-sdk-2.1.105`

2. But you can always find the most up-to-date one here: https://www.microsoft.com/net/core#ubuntu

##### Everyone else

https://www.microsoft.com/net/core

### Download

Clone or download [this github repository](https://github.com/nopara73/BitcoinGenie/).

`git clone  https://github.com/nopara73/BitcoinGenie.git`

### Build  
  
1. Open a command line or terminal window in BitcoinGenie/src/BitcoinGenie folder.  
2. Type:  
  `dotnet restore`  
  `dotnet build`
  
### Run:
So far you downloaded the .NET Core Framework, my project, restored its dependencies and built the software. An other way to put it: you installed it.  
  
To run the software:
  
1. Open a command line or terminal window in BitcoinGenie/src/BitcoinGenie folder.
2. Type: `dotnet run`
  
## For developers
  
It is a .NET Core Console Application, so you will need:  
* .NET Core  
* (optional) Visual Studio: Build -> Run  
