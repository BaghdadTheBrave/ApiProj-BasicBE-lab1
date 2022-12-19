
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source

#copy n' restore csproj
COPY BBE-1/*.csproj ./BBE-1/
COPY BBE-1.RAPI/*.csproj ./BBE-1.RAPI/
COPY l1.sln .
RUN dotnet restore "./l1.sln"

#copy everything else
COPY BBE-1/. .
COPY BBE-1.RAPI/. .
COPY . .
WORKDIR "/source/BBE-1/"
RUN dotnet publish -c Release -o /out --no-restore




#serve stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /out
COPY --from=build /out ./

ENTRYPOINT [ "dotnet","BBE-1.dll" ]