import {Router } from "express";
import { review_controller } from "../controller/review_controller";
import { checkJwt } from "../middleware/jwt";

const reviewRoutes = Router();

//Obtener todas las Reseñas
reviewRoutes.get('/',[checkJwt], review_controller.getAll);

//Obtener todas las Reseñas de un Restaurente o un Repartidor
//Se necesita dos parametros uno que me identifique el id del restaurante o del repartidor y otro que me defina el tipo
reviewRoutes.get('/:id:type',[checkJwt], review_controller.getReviews);

//Guardar 
reviewRoutes.post('/new',[checkJwt], review_controller.save);

//Modificar
reviewRoutes.patch('/update/:id',[checkJwt], review_controller.update);

//Eliminar
reviewRoutes.delete('/delete/:id',[checkJwt], review_controller.delete);

export default reviewRoutes;