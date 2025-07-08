#  Sistem de Ambalare Produse

##  Descriere

Aplicația este un **sistem de ambalare produse** care:

- Primește un tip de produs introdus de utilizator (`Book`, `Glass`, `Laptop`)
- Creează obiectul corespunzător printr-un **Factory Pattern**
- Aplică automat strategia potrivită de ambalare prin **Strategy Pattern**
- Afișează ambalajul recomandat


##  Arhitectură
Sistem de Ambalare Produse/
├── ProductPackaging/              # Proiect principal
│   ├── Interfaces/                # IProduct, IPackagingStrategy
│   ├── Products/                  # Book, Glass, Laptop
│   ├── Strategy/                  # 3 tipuri de ambalare
│   ├── Factory/                   # ProductFactory.cs
│   ├── Services/                  # PackagingService.cs
│   └── Program.cs                 # Punctul de start
│
└── ProductPackaging.Tests/        # Proiect de teste xUnit
    └── PackagingTests.cs



##  Design Patterns folosite

### 🔹 1. Factory Pattern
- Clasa: ProductFactory
- Rol: creează obiecte de tip produs (Book, Glass, Laptop) pe baza unui string

### 🔹 2. Strategy Pattern
- Clasa: PackagingService + strategii
- Rol: aplică dinamically strategia potrivită de ambalare (fragil, electronic, standard)

## Exemplu 

Enter product type (book/glass/laptop): glass

Product: Glass Bottle  
Packaging: Fragile Bubble Wrap

 
 
