# 🛡️ Cybersecurity Awareness Chatbot
### PROG6221

A C# console-based chatbot that educates users on cybersecurity topics.

---

## Features
- 🔊 Voice greeting on startup (`greeting.wav`)
- 🎨 ASCII art banner
- 👤 Personalised user interaction
- 💬 Responds to cybersecurity topics: passwords, phishing, malware, VPN, ransomware, 2FA, and more
- ✅ Input validation (empty & unknown input handling)
- 🌈 Coloured console UI with typing effect

## Project Structure
```
/CybersecurityBot
├── Program.cs        ← Entry point
├── Chatbot.cs        ← Core conversation logic & UI
├── User.cs           ← User model
├── AudioPlayer.cs    ← WAV greeting player
├── greeting.wav      ← Voice greeting file (add your own)
├── README.md
└── .github/workflows/dotnet.yml  ← GitHub Actions CI
```

## How to Run
1. Open the project in **Visual Studio**
2. Add your `greeting.wav` file to the project root (set *Copy to Output Directory = Always*)
3. Press **F5** to run

## Supported Topics
| Keyword | Topic |
|---|---|
| `password` | Strong password advice |
| `phishing` | Email/link scams |
| `malware` | Malicious software |
| `firewall` | Network protection |
| `vpn` | Virtual Private Networks |
| `ransomware` | File encryption attacks |
| `2fa` / `two-factor` | Two-Factor Authentication |
| `encryption` | Data encryption |
| `wifi` | Wi-Fi safety |
| `backup` | Data backup strategy |

## CI/CD
GitHub Actions automatically builds the project on every push via `.github/workflows/dotnet.yml`.
