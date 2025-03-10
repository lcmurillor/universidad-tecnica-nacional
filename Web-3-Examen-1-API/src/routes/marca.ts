import { Router } from "express";
import { marcaController } from "../controller/marcaController";

const marca_routes = Router();
/**
 * Ruta que permite guardar una nueva marca en la base de datos mediante la ruta POST "http://localhost:3000/marca/".
 */
marca_routes.post('/', marcaController.save);
/**
 * Ruta que permite actualizar una marca ya registrada en la base de datos, identificando esta mediante le id. Con la ruta PATCH "http://localhost:3000/marca/{:id}"
 */
marca_routes.patch('/:id', marcaController.update);
/**
 * Ruta que permite eliminar una marca ya registrada en la base de datos, identificando esta mediante le id. Con la ruta DELETE "http://localhost:3000/marca/{:id}"
 */
marca_routes.delete('/:id', marcaController.delete);
/**
 * Ruta que permite obtener los datos guardados en la base de datos correspondientes a una marca identificando esta mediante el id. Con la ruta GET "http://localhost:3000/marca/{:id}"
 */
marca_routes.get('/:id', marcaController.get);
/**
 * Ruta que permite obtener los datos guardados en la base de datos correspondientes a todas las marcas. Con la ruta GET "http://localhost:3000/marca/"
 */
marca_routes.get('/', marcaController.getAll);

export default marca_routes;