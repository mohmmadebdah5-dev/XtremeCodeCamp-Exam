# Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["XtremeCodeCampExam.csproj", "."]
RUN dotnet restore "XtremeCodeCampExam.csproj"
COPY . .
RUN dotnet publish "XtremeCodeCampExam.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Run
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://0.0.0.0:10000
EXPOSE 10000
ENTRYPOINT ["dotnet", "XtremeCodeCampExam.dll"]
