import { useEffect, useState } from "react"



function App() {

    const [products, setProducts] = useState<{ name: string, price: number }[]>([]);
    useEffect(() => {
         function getData() {
            try {
                 fetch('http://localhost:5193/api/products').then(response => response.json()
                    .then(data => setProducts(data)))
            } catch (err) {
                console.log(err)
            }
        }
        getData();


    }, [])
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
