# My First Electron App

A simple Electron desktop application with two features:
1. **Greet Me** - Enter your name and get a personalized greeting
2. **Add Two Numbers** - Add two numbers together

## Getting Started

### Prerequisites
- Node.js (v16 or higher)
- npm (comes with Node.js)

### Installation

1. Install dependencies:
```bash
npm install
```

2. Run the app:
```bash
npm start
```

## Project Structure

```
ElectronApp/
├── main.js          # Main Electron process (creates window)
├── index.html       # UI structure (HTML)
├── styles.css       # Styling (CSS)
├── renderer.js      # Frontend logic (JavaScript)
├── package.json     # Project configuration
└── README.md        # This file
```

## How It Works

- **main.js**: Creates the Electron window and loads the HTML
- **index.html**: The UI structure (like XAML in C#)
- **styles.css**: Makes it look beautiful (like styling in C#)
- **renderer.js**: Handles user interactions (like your C# event handlers)

## Building for Distribution

To create a distributable app:

```bash
# Install electron-builder
npm install --save-dev electron-builder

# Build for your platform
npx electron-builder
```

## Learning Resources

- [Electron Documentation](https://www.electronjs.org/docs)
- [HTML/CSS/JavaScript Basics](https://developer.mozilla.org/)

