FROM cl0sey/dotnet-mono-node-docker

WORKDIR /app

ADD bower.json /app/bower.json
RUN bower install --allow-root

ADD project*.json /app/
RUN dotnet restore

ADD . /app

RUN dotnet publish --configuration Release
RUN ln -s /usr/share/dotnet/shared/Microsoft.NETCore.App/1.0.0/System.Native.so /app/bin/Release/net451/ubuntu.14.04-x64/publish/libSystem.Native.so
EXPOSE 5000

CMD ["mono", "bin/Release/net451/ubuntu.14.04-x64/publish/app.exe"]
