# ObserwatoriumXR

Aplikacja XR do wizualizacji obiektów dziedzictwa kulturowego stworzona przy użyciu Unity i metodyki Reality Capture.

## 📋 O Projekcie

Projekt został zrealizowany w ramach pracy inżynierskiej pt. **"Wykorzystanie metodyki Reality Capture do budowy modeli obiektów dziedzictwa kulturowego oraz ich optymalizacji na potrzeby rozwiązań typu eXtended Reality"**.

Aplikacja umożliwia interaktywne poznawanie obiektów dziedzictwa kulturowego w środowisku rozszerzonej rzeczywistości (XR), wykorzystując zaawansowane techniki fotogrametrii i optymalizacji modeli 3D.

### 🏛️ Obiekt Badawczy

Do realizacji części praktycznej jako obiekt dziedzictwa kulturowego wybrano **budynek Obserwatorium Astronomicznego w Olsztynie**. Obiekt wybrano ze względu na jego wyjątkowe walory kulturowe oraz bogatą historię.

## 🎯 Cel Projektu

Głównym celem projektu jest:
- Digitalizacja obiektów dziedzictwa kulturowego z wykorzystaniem metodyki Reality Capture
- Optymalizacja modeli 3D na potrzeby aplikacji XR
- Stworzenie interaktywnego doświadczenia w rozszerzonej rzeczywistości
- Zachowanie i udostępnienie cyfrowych reprezentacji zabytków

## 🛠️ Technologie

- **Unity** - silnik do tworzenia aplikacji mobilnych i AR
- **ARCore** (Google AR) - framework do rozszerzonej rzeczywistości na Androida
- **AR Foundation** - Unity framework do tworzenia aplikacji AR
- **Reality Capture** - oprogramowanie do fotogrametrii i tworzenia modeli 3D
- **C#** - język programowania
- **Android SDK** - narzędzia deweloperskie dla platformy Android

## 📂 Struktura Projektu

```
ObserwatoriumXR/
├── Assets/              # Zasoby Unity (modele, materiały, skrypty)
├── Packages/            # Pakiety i zależności Unity
├── ProjectSettings/     # Ustawienia projektu Unity
├── .gitignore          
└── .vsconfig           # Konfiguracja Visual Studio
```

## 🚀 Wymagania Systemowe

### Dla urządzenia docelowego (Android):
- System operacyjny: **Android 7.0 (API level 24) lub nowszy**
- Procesor: ARMv7 lub ARM64
- RAM: minimum 2 GB (zalecane 4 GB)
- Wsparcie dla ARCore (Google AR)
- Aparat fotograficzny

### Dla środowiska deweloperskiego:
- System operacyjny: Windows 10/11, macOS lub Linux
- Unity Editor: 2020.3 LTS lub nowszy
- Android SDK
- JDK (Java Development Kit)
- RAM: 8 GB (zalecane 16 GB)

> **Uwaga:** Ta wersja aplikacji działa wyłącznie na urządzeniach z systemem Android. Wymaga telefonu z obsługą ARCore.

## 💻 Instalacja

1. Sklonuj repozytorium:
```bash
git clone https://github.com/jakubdeoniziak/ObserwatoriumXR.git
```

2. Otwórz projekt w Unity Hub:
   - Uruchom Unity Hub
   - Kliknij "Add" i wskaż folder projektu
   - Otwórz projekt odpowiednią wersją Unity

3. Poczekaj na zaimportowanie assetów i kompilację skryptów

## 🎮 Uruchomienie

### Testowanie w Unity Editor:
1. W Unity Editor otwórz główną scenę z folderu `Assets/Scenes/`
2. Naciśnij przycisk Play (symulacja AR w edytorze może być ograniczona)

### Uruchomienie na urządzeniu Android:
1. Podłącz telefon Android do komputera przez USB
2. Włącz opcje deweloperskie i debugowanie USB na telefonie
3. W Unity: File → Build Settings → wybierz Android → Build and Run
4. Aplikacja zostanie zainstalowana i uruchomiona na telefonie

## 📱 Budowanie Aplikacji

### Dla urządzeń Android:
1. File → Build Settings
2. Wybierz platformę **Android**
3. Switch Platform
4. Player Settings → sprawdź konfigurację:
   - Minimum API Level: Android 7.0 (API level 24)
   - Target API Level: najnowszy dostępny
   - ARCore Support: włączony
5. Build and Run lub Build (tworzenie pliku APK)

> **Wskazówka:** Plik APK można zainstalować bezpośrednio na telefonie Android lub udostępnić innym użytkownikom.

## 🎨 Funkcjonalności

- ✅ Wizualizacja wysokojakościowego modelu 3D Obserwatorium Astronomicznego w Olsztynie
- ✅ Technologia AR (Augmented Reality) na urządzeniach Android
- ✅ Interaktywna eksploracja modelu w przestrzeni rzeczywistej
- ✅ Optymalizacja wydajności dla urządzeń mobilnych
- ✅ Intuicyjny interfejs użytkownika dostosowany do ekranów dotykowych
- ✅ Wsparcie dla ARCore (Google AR)

## 📊 Metodyka Realizacji Projektu

Projekt został zrealizowany zgodnie z następującym procesem:

### 1️⃣ Wybranie obiektu dziedzictwa kulturowego do pracy
Etap badawczy i koncepcyjny:
- Analiza dostępnych obiektów dziedzictwa kulturowego
- Wybór obiektu odpowiedniego do digitalizacji
- Określenie celów i zakresu projektu

### 2️⃣ Pozyskanie danych za pomocą TSL i UAV
Etap akwizycji danych:
- **TSL (Terrestrial Laser Scanning)** - skanowanie laserowe terenu z poziomu gruntu
- **UAV (Unmanned Aerial Vehicle)** - fotogrametria lotnicza z wykorzystaniem dronów
- Wykonanie serii zdjęć z różnych perspektyw i wysokości
- Zapewnienie odpowiedniego pokrycia i jakości zdjęć

### 3️⃣ Opracowanie modelu 3D w oprogramowaniu Reality Capture
Etap przetwarzania i modelowania:
- Import zebranych danych (zdjęcia TSL i UAV)
- Wyrównanie zdjęć i kalibracja
- Generowanie gęstej chmury punktów
- Tworzenie meshu 3D
- Teksturowanie modelu
- Optymalizacja i czyszczenie geometrii

### 4️⃣ Napisanie aplikacji AR na telefon z systemem Android na silniku Unity
Etap implementacji:
- Konfiguracja projektu Unity dla platformy Android
- Import zoptymalizowanego modelu 3D
- Implementacja funkcjonalności AR
- Projektowanie interfejsu użytkownika
- Optymalizacja wydajności dla urządzeń mobilnych
- Testowanie na docelowych urządzeniach

### 5️⃣ Podsumowanie i sformułowanie wniosków
Etap finalizacji:
- Analiza wyników projektu
- Sformułowanie wniosków i rekomendacji
- Dokumentacja procesu i wyników

## 🔄 Pipeline Techniczny

```
Obiekt fizyczny
      ↓
[TSL + UAV] → Zdjęcia/Skany
      ↓
[Reality Capture] → Model 3D wysokiej jakości
      ↓
[Optymalizacja] → Model zoptymalizowany dla mobile
      ↓
[Unity + AR Foundation] → Aplikacja AR Android
      ↓
Interaktywne doświadczenie AR
```

## 🔧 Optymalizacja

Zastosowane techniki optymalizacji:
- Redukcja liczby poligonów (retopology)
- Kompresja tekstur
- Systemy LOD (Level of Detail)

## 📄 Licencja

Projekt edukacyjny - praca inżynierska.

## 👨‍💻 Autor

**Jakub Deoniziak**
- GitHub: [@jakubdeoniziak](https://github.com/jakubdeoniziak)

## 🙏 Podziękowania

- Promotor pracy inżynierskiej
- Instytucje udostępniające obiekty do digitalizacji
- Społeczność Unity i Reality Capture

---

*Projekt zrealizowany w ramach pracy inżynierskiej na temat wykorzystania metodyki Reality Capture w ochronie dziedzictwa kulturowego.*
