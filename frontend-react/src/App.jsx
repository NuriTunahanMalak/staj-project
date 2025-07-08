import { useState } from 'react'
import reactLogo from './assets/react.svg'  //Bu dosyaları bileşen olarak alır.
import viteLogo from '/vite.svg'
import './App.css'

// 💡 Yeni eklenen import!
import Button from './components/Button'

function App() {
    const [count, setCount] = useState(0)

    const handleClick = () => {
        setCount(count + 1)
    }

    return (
        <>
            <div>
                <a href="https://vite.dev" target="_blank" rel="noreferrer">
                    <img src={viteLogo} className="logo" alt="Vite logo" />
                </a>
                <a href="https://react.dev" target="_blank" rel="noreferrer">
                    <img src={reactLogo} className="logo react" alt="React logo" />
                </a>
            </div>
            <h1>Vite + React</h1>
            <div className="card">
                {/* Orijinal button yerine kendi Button bileşenini kullan */}
                <Button label={`count is ${count}`} onClick={handleClick} />

                <p>
                    Edit <code>src/App.jsx</code> and save to test HMR
                </p>
            </div>
            <p className="read-the-docs">
                Click on the Vite and React logos to learn more
            </p>
        </>
    )
}

export default App
