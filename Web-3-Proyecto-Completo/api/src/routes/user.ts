import {Router } from "express";
import { address_controller } from "../controller/address_controller";
import { user_controller } from "../controller/user_controller";
import { checkJwt } from "../middleware/jwt";

const usuarioRoutes = Router();

//Obtener todos los Usuarios
usuarioRoutes.get('/', user_controller.getAll);

//Obtener solo un Usuario
usuarioRoutes.get('/:id',[checkJwt], user_controller.getOne);

//Obtener Todas las Direcciones de un Usuario
usuarioRoutes.get('/list/address/:id',[checkJwt], address_controller.getUserAddress);

//Guardar 
usuarioRoutes.post('/new', user_controller.save);

//Modificar
usuarioRoutes.patch('/update/:id',[checkJwt], user_controller.update);

//Eliminar
usuarioRoutes.delete('/delete/:id',[checkJwt], user_controller.delete);

export default usuarioRoutes;