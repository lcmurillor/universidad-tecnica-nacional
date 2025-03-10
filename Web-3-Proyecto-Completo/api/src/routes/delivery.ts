import { delivery_controller } from '../controller/delivery_controller';
import {Router } from "express";
import { vehicle_Controller } from '../controller/vehicle_controller';
import { checkJwt } from '../middleware/jwt';

const deliveryRoutes = Router();


//Obtener todos los productos
deliveryRoutes.get('/',[checkJwt],delivery_controller.getAllDelivery);

//Obtener solo un producto
deliveryRoutes.get('/:id',[checkJwt],delivery_controller.getOneDelivery);

//Guardar 
deliveryRoutes.post('/',[checkJwt],delivery_controller.createDelivery);

//Modificar
deliveryRoutes.patch('/:id',[checkJwt],delivery_controller.updateDelivery);

//Eliminar
deliveryRoutes.delete('/:id',[checkJwt],delivery_controller.deleteDelivery);

//Crear Vehiculo
deliveryRoutes.post('/vehicle/new',[checkJwt], vehicle_Controller.createVehicle);

//Obtener un vehiculo
deliveryRoutes.get('/vehicle/:id',[checkJwt], vehicle_Controller.getOneVehicle);

//Actualizar vehiculo
deliveryRoutes.patch('/vehicle/update/:id',[checkJwt],vehicle_Controller.updateVehicle);

//Eliminar vehiculo
deliveryRoutes.delete('/vehicle/delete/:id',[checkJwt],vehicle_Controller.deleteVehicle);


export default deliveryRoutes;