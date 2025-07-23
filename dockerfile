FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
EXPOSE 186
WORKDIR /src

COPY ["SIDS/SIDS.csproj", "SIDS/"]

RUN dotnet restore "SIDS/SIDS.csproj"

COPY . .

WORKDIR "/src/SIDS"
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "SIDS.dll"]