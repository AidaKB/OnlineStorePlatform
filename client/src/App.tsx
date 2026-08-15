import { useState } from "react"



function App() {
  
    const [products, setProducts] = useState([{ name: "phone", price: 15222 },
        { name: "laptop", price: 878745 }]);
    const addProduct = () => {
        setProducts(prevState => [...prevState, { name: "product" + (prevState.length + 1), price: prevState[prevState.length - 1].price + 100 }])
    }
    return (
        <div>
            <h1 style={{ color: 'red' }}>Re Store</h1>
            <ul>
                {products.map((item , index) => (
                    <li key={index}>{item.name} - {item.price}</li>
                ))}
            </ul>
            <button onClick={() => addProduct()}>Add Product</button>
        </div>
  )
}

export default App
