# DDNS Now IP Address Changer

IPv4, v6 アドレスを自動で取得し，DDNS Now の設定を自動変更するツールです。

# インストール方法

## ビルド

1. リポジトリを任意のディレクトリにクローン
2. [Visual Studio 2019](https://visualstudio.microsoft.com/ja/downloads/) 以降を使用してビルド
3. 完了

## 使い方

1. ビルドすると生成される `DDNS Now IP Address Changer.exe.config` の 14 行目に `ユーザー名 か ドメイン名` を入力
2. 17 行目に API 用トークンを入力
   - API 用トークンは [DDNS Now](https://ddns.kuku.lu) にログインし， `詳細設定` の下にある `API用トークン` を開くと入手出来ます。
3. `DDNS Now IP Address Changer.exe` を実行
