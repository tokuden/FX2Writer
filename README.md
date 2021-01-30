# FX2Writer説明書
2021年1月30日作成  
(C)Copyright 特殊電子回路株式会社

## 概要
このソフトウェアは、EEPROM Missing状態のEZ-USB FX2にファームウェアを書き込むためのものです。

EZ-USB FX2は、EEPROMが接続されていない状態か、EEPROMの内容が空であるとき、  
VID=0x04b4 PID=0x8613のデバイスとして認識され、cyusbというデバイスドライバが組み込まれます。

この状態で起動したEZ-USBに対して、EEPROMあるいは内蔵RAMにファームウェアを転送します。  
RAMに転送した場合はすぐに再起動され新しいファームウェアで動作します。  
ROMに転送した場合は、USBデバイスを再起動(通常は電源OFF/ON)で新しいファームウェアで動作します。

## 使い方
EEPROM Missing状態のFX2デバイスとPCをUSBで接続し、以下の手順で書き込みます。

1. テキストボックスに書き込みたいファームウェアのファイル名を指定します。

> firmwareフォルダには[特電Spartan-6ボード](http://www.tokudenkairo.co.jp/sp6/)のためのファームウェアファイルnp1027.iicと、  
[特電Spartan-7ボード](http://www.tokudenkairo.co.jp/sp7/)のためのファームウェアファイルnp1116.iicが入っています。

2. RAMに書き込むか、EEPROMに書き込むかを選択します。
3. Programボタンを押します。

---
## FX2LP EEPROM Missingのデバイスドライバが見つからない場合
FX2LP EEPROM Missingデバイス(04b4:8163)用のデバイスドライバが見つからない場合は、  
cyusb-driveri-win8.1-x64 フォルダを参照してください。  
これはWindows8.1 x64用のドライバですが、Windows 10でも使用できます。

上記以外のOS版が必要な場合はCypressのEZ-USB FX2LP開発キットを参照してください。

## 消去する方法
FX2LPが新しいファームウェアで起動すると、  
VIDとPIDが変更されて独自の専用デバイスドライバで動作するため、cyusbは使用できなくなります。

特殊電子回路株式会社のSpartan-6ボード用はezusb.sysという古いタイプのCypress EZ-USB FX2ドライバで動作しており、  
このファームウェアとドライバ用にEraserというソフトウェアを用意しています。消去はEraserを使用してください。

## RAMとROMの使い分け
RAMに書き込んだファームウェアは電源をOFFにすると消去されるので、ファームウェア自体を開発する場合のテストに向いています。  
ROMに書き込んだファームウェアは電源OFFでも消えないので、ある程度ファームウェアの開発が進んだ段階や、製品リリースの際に使います。

---
## ライセンス
アプリの利用、ソースコードの参照ともに、利用者の責任の範囲で自由に使用して構いません。
