# Workplace-advisor

## Run on Linux

### Install packages for .net core


``` sudo apt-get update && sudo apt-get install -y --no-install-recommends libc6 libgcc1 libgssapi-krb5-2 libicu66 libssl1.1 libstdc++6 zlib1g ```

### Download the SDK 3.1.424

Extract file to a good location ex:

``` mkdir -p $HOME/dotnet && tar zxf dotnet-sdk-3.1.424-linux-x64.tar.gz -C $HOME/dotnet ```

Export env to use the correct SDK

```
export DOTNET_ROOT=$HOME/dotnet
export PATH=$PATH:$HOME/dotnet
```

### run the project:

```
cd $PROJECT_ROOT/WorkPlaceAdvisor && dotnet run
```

###  install mmsql for ubuntu
https://learn.microsoft.com/en-us/sql/linux/quickstart-install-connect-ubuntu?view=sql-server-ver16
