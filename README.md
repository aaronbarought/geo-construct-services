# geo-construct-services

# Geo-Construct Services 🌍

A **C# ASP.NET web platform** for real-time **disaster tracking**, integrating **weather** and **earthquake monitoring APIs** using **WCF, SOAP, and RESTful services**.

## Features 🚀
✅ Real-time **earthquake and weather data** integration  
✅ Secure **user authentication with SHA-256 password encryption & CAPTCHA**  
✅ API communication using **WCF, SOAP, and RESTful web services**  
✅ **Optimized XML processing** for storing and managing disaster reports  
✅ **Deployed on ASU servers** for live monitoring  


## Code Structure 🏗

### 📂 `WebApplication1/`
- **`Controllers/`** → Handles API requests for earthquake/weather data.
- **`Models/`** → Defines database models for users and disasters.
- **`Views/`** → Frontend UI (HTML, Razor).
- **`Web.config`** → Manages database connections & API keys.
- **`Scripts/`** → JavaScript for real-time updates & interactive maps.

  
### **1️⃣ Class Library**
- **`WebApplication1/ClassLibrary1/Class1.cs`**  
  - C# class library containing **utility functions**.  
  - Likely used for **data encryption, API communication, or file processing**.

### **2️⃣ Configuration**
- **`WebApplication1/Web.config`**  
  - Core **configuration file** for the ASP.NET application.  
  - Defines **database connections, API keys, authentication settings, and WCF configurations**.

### **3️⃣ Database & Data Storage**
- **`WebApplication1/App_Data/`**  
  - Stores **database files or XML data** related to **earthquake/weather monitoring**.

### **4️⃣ API & Controllers**
- **`WebApplication1/Controllers/`**  
  - Contains C# **controller files** that handle **API requests and user interactions**.  
  - **Key Controllers:**
    - `DisasterController.cs` → Handles **earthquake and weather API requests**.
    - `UserAuthController.cs` → Manages **user authentication** (CAPTCHA, password encryption).

### **5️⃣ Frontend & Views**
- **`WebApplication1/Views/`**  
  - Contains **HTML & Razor templates** for the frontend UI.  
  - **Key Views:**
    - `Index.cshtml` → Homepage showing **disaster alerts**.
    - `Login.cshtml` → User **authentication page**.

### **6️⃣ Models (Data Handling)**
- **`WebApplication1/Models/`**  
  - Defines **data models** for the application.  
  - **Key Models:**
    - `DisasterModel.cs` → Represents **earthquake or weather event data**.
    - `UserModel.cs` → Stores **user credentials** (hashed passwords, session data).

### **7️⃣ Scripts & Frontend Logic**
- **`WebApplication1/Scripts/`**  
  - Contains **JavaScript files** used for frontend interactions.  
  - **Key Script:**
    - `map.js` → Uses **Google Maps API or MapKit** for displaying disaster locations.




## Installation 🛠
1. **Clone the repository**  
   ```bash
   git clone https://github.com/aaronbarought/geo-construct-services.git
