Lane Monitor SCADA Prototype

A desktop C# WinForms application designed to simulate a SCADA-style monitoring system. 
It automatically loads lane configurations from a database, connects to 4 Hikvision cameras per lane,
pulls scheduled snapshots on a background timer,
saves them to a structured file hierarchy, and logs camera connectivity failures to an incident database.

## 🚀 Key Features

Dynamic SCADA Grid: Automatically populates rows and camera viewports based on the lanes retrieved from the database.
Automated Image Capture: Utilizes asynchronous HTTP requests to fetch live snapshots from Hikvision cameras on a configurable timer without freezing the user interface.
Structured Local Storage: Organizes and saves captured snapshots automatically following a precise timestamp and directory hierarchy:
  
```
  LaneName/
  └── CameraName/
      └── DDMMMYYYY/
          ├── HH_mm_ss_CameraName.png
          └── HH_mm_ss_CameraName.png
