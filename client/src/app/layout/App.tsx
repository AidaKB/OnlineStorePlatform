import { useEffect, useState } from "react"
import type { Product } from "../models/product";
import Catalog from "../../features/catalog/Catalog";
import { Box, Button, Container, Typography } from "@mui/material";



function App() {

    const [products, setProducts] = useState<Product[]>([]);
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
        setProducts(prevState => [...prevState, {

            id: prevState.length + 1,
            name: 'product' + (prevState.length + 1),
            price: (prevState.length * 100) + 100,
            quantityInStock: 100,
            description: 'test',
            pictureUrl: 'https://picsum.photo/200',
            type: 'test',
            brand: 'test'
        }])
    }
    return (
        <Container maxWidth="xl">
            <Box
                sx={{
                    display: "flex",
                    justifyContent: "center",
                    gap: 3,
                    marginY: 3
                }}
            >
                <Typography variant="h4">
                    Re Store
                </Typography>

                <Button
                    variant="contained"
                    onClick={() => addProduct()}
                >
                    Add Product
                </Button>
            </Box>

            <Catalog products={products} />
        </Container>
  )
}

export default App
