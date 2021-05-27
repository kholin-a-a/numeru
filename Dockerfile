FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build-env
WORKDIR /app

COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:3.1 as runtime-env
WORKDIR /app
COPY  --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Numeru.Web.dll"]