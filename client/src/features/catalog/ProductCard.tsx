import {
    Button,
    Card,
    CardActions,
    CardContent,
    CardMedia,
    Typography
} from "@mui/material";

import type { Product } from "../../app/models/product";

type Props = {
    product: Product;
};

export default function ProductCard({ product }: Props) {
    return (
        <Card elevation= { 3} >
        <CardMedia
                sx={
        {
            height: 240, //ارتفاع عکس
                backgroundSize: "cover" //تصویر کامل تویکارت بیفته
        }
    }
    image = { product.pictureUrl } //تصویر رو از url میخونه
    title = { product.name } // اسم محصول روبروی عکسش
        />

        <CardContent>
        <Typography   //برای نمایش متن در mui
                    gutterBottom // پایین متن فاصله ایجاد کن
    sx = {{
        textTransform: "uppercase" // متن با حروف بزرگ نمایش داده بشه
    }
}
variant = "subtitle2"  //استایل مخصوص متن
    >
    { product.name }
    < /Typography>

    < Typography
variant = "h5"
sx = {{
    color: "secondary.main"
}}
                >
    ${ (product.price / 100).toFixed(2) }
</Typography>
    < /CardContent>

    < CardActions // اکشن های کارت
sx = {{
    justifyContent: "space-between"   //دوتا یاتم از هم فاصله بگیرن
}}
            >
    <Button>
    Add to cart
        < /Button>

        <Button>
        View
    < /Button>
    < /CardActions>
    < /Card>
    );
}