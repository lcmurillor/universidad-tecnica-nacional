import {Router } from "express";
import { product_category_controller } from "../controller/product_category_controller";
import { product_controller } from "../controller/product_controller";
import { checkJwt } from "../middleware/jwt";

const productRoutes = Router();

//Obtener todos los productos
productRoutes.get('/list/:business',[checkJwt],product_controller.getAllProduct);

//Obtener solo un producto
productRoutes.get('/:id',[checkJwt],product_controller.getOneProduct);

//Crear
productRoutes.post('/new',[checkJwt], product_controller.createProduct);

//Modificar
productRoutes.patch('/update/:id',[checkJwt], product_controller.updateProduct);

//Eliminar
productRoutes.patch('/delete/:id',[checkJwt], product_controller.deleteProduct);

//Obtener todos las categorias
productRoutes.get('/product_category/list',[checkJwt],product_category_controller.getAllProductCategory);

//Obtener solo una categoria
productRoutes.get('/product_category/:id',[checkJwt],product_category_controller.getOneProductCategory);

export default productRoutes;