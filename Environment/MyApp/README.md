## .NET Core 101

https://learn.microsoft.com/ja-jp/shows/net-core-101/

## .NETの概要

https://dotnet.microsoft.com/ja-jp/learn/dotnet/hello-world-tutorial/intro?&WT.mc_id=Educationaldotnet-c9-scottha

## .NETチュートリアル5分でできるHello World
[環境構築はこれ](../environment.md)

- アプリを作成
```
dotnet new console -o MyApp -f net7.0
```

- 作成したディレクトリへ移動
```
cd MyApp
```

## コマンドの意味
`dotnet new console` = コンソールアプリを作成
`-o` = 必要なファイルとともにアプリが格納され、設置される MyApp という名前のディレクトリを作成
`-f` = .NET 7 アプリケーションを作成していることを示す

## アプリケーションを実行
```
dotnet run
```

## コードを編集する
```csharp:Program.cs
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);
```
