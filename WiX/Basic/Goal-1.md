# GOAL 1: We want an installer that install with one click.

To achieve this, we will need to first build the project to get the `Sir Answers-a-Lot.exe`.

## Preparing the executable

### Dependencies to build the project

- .NET 9+

### Process

- `cd` to the directory called `Sir Answers-a-Lot`
- Then call

  ```bash
  dotnet publish -c Release -r YOUR_OS --self-contained true
  ```

- `YOUR_OS` should be one of these

  - `win-x64`
  - `linux-x64`
  - `osx-x64`.

- When complete you should be able to see an executable called `Sir Answers-a-Lot.exe` in `bin/Release/net9.0/YOUR_OS/publish` with all other .dll.

## Let's actually start on building installer.

### Prequisuite

- .NET SDK

### Process

1. Create a new folder called `Installer` (You can change `Installer` with anything you like)
2. Create a new file in the project called `Installer.wixproj` with the following content
   ```xml
   <Project Sdk="WixToolset.Sdk/6.0.1">
   </Project>
   ```
3. Create a new WiX source file named `Package.wxs` with the following content.

   ```xml
   <Wix xmlns="http://wixtoolset.org/schemas/v4/wxs">
    <Package Id="TODO_Manufacturer.WiXInstaller"
          Name="WiXInstaller"
          Manufacturer="TODO Manufacturer"
          Version="1.0.0.0">
      <Feature Id="Main">
        <ComponentGroupRef Id="ExampleComponents" />
      </Feature>
    </Package>
   </Wix>
   ```

#### Package component

Where:

- Id: An attribute used for idetifying your installer. This will play in a big role for your installer to know whether it was already installed on the machine or not. Recommmend using your company name or owner name of the software as a prefix. (Ex. `RedGate.WiXInstaller`)
- Name: An attribute that will set your installed software name. (It will be show in the `Installed app` list)
- Manufacturer: An attribute that will claim who made the software. (It willl also be show in the `Installed app` list)
- Version: Attribute to set version of the installer. This will also be use to determine whether installer will run as upgrade or downgrade mode.

#### Feature component

- MSI will require at least one feature. Now that you add it you can add anything in the installer inside this component to make it relevant.
