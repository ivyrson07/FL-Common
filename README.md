﻿# FL.Common Package

This is a README file generated by [`ChatGPT`](https://chat.openai.com/auth/login), providing instructions on how to create and publish the package locally.
(This package will be referenced by the WebApp and Microservices)

## Step 1: Prerequisites

Before you begin, ensure you have the following tools installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [NuGet CLI](https://docs.microsoft.com/en-us/nuget/install-nuget-client-tools) (optional)

## Step 2: Define Package Metadata

NuGet packages contain metadata that describe the package and its contents. You can define this metadata in either a `.nuspec` file or your project's `.csproj` file.

### Option 1: Using a `.nuspec` File (Traditional Approach)

1. Create a `.nuspec` file in your project directory.

    ```xml
    <?xml version="1.0"?>
    <package xmlns="http://schemas.microsoft.com/packaging/2011/08/nuspec.xsd">
      <metadata>
        <id>FL.Common</id>
        <version>1.0.0</version>
        <authors>Your Name</authors>
        <owners>Your Name</owners>
        <description>A short description of your package</description>
      </metadata>
    </package>
    ```

2. Customize the metadata elements in the `.nuspec` file as needed for your package.

### Option 2: Using Your `.csproj` File (Recommended for .NET Core and .NET 5+ Projects)

1. Open your project's `.csproj` file.

2. Add the package-related properties inside a `<PropertyGroup>` element.

    ```xml
    <PropertyGroup>
      <TargetFramework>net5.0</TargetFramework>
      <PackageId>FL.Common</PackageId>
      <Version>1.0.0</Version>
      <Authors>Your Name</Authors>
      <Description>A short description of your package</Description>
    </PropertyGroup>
    ```

## Step 3: Build Your Project

Before creating the NuGet package, build your project to ensure that the assembly and other necessary files are generated.

```bash
dotnet build
```

## Step 4: Pack the Project

To create the NuGet package, use the `dotnet pack` command.

```bash
dotnet pack -c Release -o ./output
```

## Step 5: Publish the Package Locally (Optional)

To test the package locally before publishing it, you can add your local package source using the `nuget sources add` command.

```bash
cd C:\directory_of_your_nuget_package\FL.Common.1.0.0.nupkg
C:\directory_of_your_nugetexe\nuget.exe add FL.Common.1.0.0.nupkg -source C:\LocalNuget
```

OR 

```bash
nuget add name_of_your_package.npkg -source /path/to/your/output/directory
```

## Step 6: Add Your Source Directory to Package Sources

In Visual Studio, go to `Tools > Nuget Package Manager > Package Manager Settings > Package Sources`. Add the directory of your local nuget source (C:\LocalNuget).

For more advanced packaging features and options, refer to the official [NuGet documentation](https://docs.microsoft.com/en-us/nuget/overview/creating-packages).