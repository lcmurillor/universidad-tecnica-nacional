import { Router } from "express";
import { address_controller } from "../controller/address_controller";
import { checkJwt } from "../middleware/jwt";

const addressRoutes = Router();

//Obtener solo una Dirección
addressRoutes.get('/:id',[checkJwt],address_controller.getOne);

//Guardar 
addressRoutes.post('/new/',[checkJwt],address_controller.save);

//Modificar
addressRoutes.patch('/update/:id',[checkJwt],address_controller.update);

//Eliminar
addressRoutes.delete('/delete/:id',[checkJwt],address_controller.delete);

export default addressRoutes;