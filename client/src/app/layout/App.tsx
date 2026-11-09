import { useEffect, useState } from "react"
import type { Product } from "../models/product";
import Catalog from "../../features/catalog/Catalog";
import {Container, CssBaseline, createTheme } from "@mui/material";
import NavBar from "./NavBar";
import { ThemeProvider } from "@emotion/react";
import { Box } from "@mui/material"


function App() {

    const [products, setProducts] = useState<Product[]>([]);
    const [darkMode, setDarkMode] = useState(false);
    const palleteType = darkMode ? 'dark' : 'light';

    const them = createTheme({
        palette: {
            mode: palleteType,
            background: {
                default: palleteType === 'light' ? '#eaeaea' : '#121212'
            }
        }
    })
    function toggleDarkMode () {
        setDarkMode(previous => !previous);
    }
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
    //const addProduct = () => {
    //    setProducts(prevState => [...prevState, {

    //        id: prevState.length + 1,
    //        name: 'product' + (prevState.length + 1),
    //        price: (prevState.length * 100) + 100,
    //        quantityInStock: 100,
    //        description: 'test',
    //        pictureUrl: 'https://picsum.photo/200',
    //        type: 'test',
    //        brand: 'test'
    //    }])
    //}
    return (
        <ThemeProvider theme={them}>
            <CssBaseline />
            <NavBar darkMode={darkMode}
                toggleDarkMode={toggleDarkMode} />
            <Box sx={{
                minHeight: '100vh',
                background: darkMode ? 'radial-gradient(circle, #1e3aba, #111B27)' : 'radial-gradient(circle, #baecf9, #f0f9ff)',
                py : 6
            } }>
                <Container maxWidth="xl" sx={{ mt: 8 }}>


                    <Catalog products={products} />
                </Container>
            </Box>
       
        </ThemeProvider>
  )
}

export default App
