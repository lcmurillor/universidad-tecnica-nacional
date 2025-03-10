import { order_controller } from '../controller/order_controller';
import {Router } from "express";
import { payment_type_controller } from '../controller/payment_type_controller';
import { checkJwt } from '../middleware/jwt';

const orderRoutes = Router();

//Obtener todos los pedidos
orderRoutes.get('/list/:id',[checkJwt],order_controller.getAll);

//Obtener solo un pedido
orderRoutes.get('/:id',[checkJwt],order_controller.getOne);

//Guardar 
orderRoutes.post('/new',[checkJwt],order_controller.createOrder);

//Modificar
orderRoutes.patch('/update/:id',[checkJwt],order_controller.updateOrder);

//Eliminar
orderRoutes.delete('/delete/:id',[checkJwt],order_controller.deleteOrder);

orderRoutes.get('/payment/type/list',[checkJwt], payment_type_controller.getAllPaymentType);

export default orderRoutes;