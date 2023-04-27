FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["TheBreakfastLibrary/TheBreakfastLibrary.csproj", "TheBreakfastLibrary/"]
RUN dotnet restore "TheBreakfastLibrary/TheBreakfastLibrary.csproj"
COPY . .
WORKDIR "/src/TheBreakfastLibrary"
RUN dotnet build "TheBreakfastLibrary.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TheBreakfastLibrary.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TheBreakfastLibrary.dll"]