const { app, BrowserWindow, shell } = require('electron')
const path = require('path')

function createWindow() {
  const mainWindow = new BrowserWindow({
    width: 1300,
    height: 750,
    minWidth: 700,
    minHeight: 650,
    webPreferences: {
      nodeIntegration: true
    },
    autoHideMenuBar: true
  })

  mainWindow.loadFile('./src/index.html')
  mainWindow.webContents.openDevTools()
}

app.whenReady().then(() => {
  createWindow()

  app.on('activate', function () {
    if (BrowserWindow.getAllWindows().length === 0) createWindow()
  })
})

app.on('window-all-closed', function () {
  if (process.platform !== 'darwin') app.quit()
})

