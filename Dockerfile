#Build stage
#Build stage
FROM mcr.microsoft.m/dontnet/sdk:10.0 ASbuild
WORKDIR /app
COPY *.csprog ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

#Runtime stage
FROM mcr.microsft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app/out ./
ENV ASPNETCORE_URLS=http://*:$PORT
EXPOSE $PORT
ENTRYPOINT ["dotnet", "CurriculumVitae.dll"]
