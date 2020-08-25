FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /csharp-web-practice

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Realese -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /csharp-web-practice
COPY --from=build-env /csharp-web-practice/out .
ENTRYPOINT ["dotnet", "web-practice.dll"]
