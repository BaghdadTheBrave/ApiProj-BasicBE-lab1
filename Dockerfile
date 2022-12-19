#build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app


COPY . .
RUN dotnet restore 
WORKDIR /app/BBE-1
RUN dotnet publish -c Release -o out



#serve stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal as runtime
WORKDIR /app
COPY --from=build /app/BBE-1/out .
#COPY ./ports.conf /etc/apache2/ports.conf
#COPY ./apache.conf /etc/apache2/sites-enabled/000-default.conf
#ENV ASPNETCORE_URLS http://*:$PORT
ENTRYPOINT [ "dotnet","BBE-1.dll" ]