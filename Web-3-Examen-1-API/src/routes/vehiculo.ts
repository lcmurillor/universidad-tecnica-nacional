import { Router } from "express";
import { vehiculoController } from "../controller/vehiculoController";

const vehiculo_routes = Router();
/**
 * Ruta que permite guardar un nuevo vehiculo en la base de datos mediante la ruta POST "http://localhost:3000/vehiculo/".
 */
vehiculo_routes.post('/', vehiculoController.save);
/**
 * Ruta que permite eliminar un vehiculo ya registrada en la base de datos, identificando esta mediante la placa. Con la ruta DELETE "http://localhost:3000/vehiculo/{:placa}"
 */
vehiculo_routes.delete('/:placa', vehiculoController.delete);
/**
 * Ruta que permite obtener los datos guardados en la base de datos correspondientes a un vehiculo identificando esta mediante la placa. Con la ruta GET "http://localhost:3000/vehiculo/{:placa}"
 */
vehiculo_routes.get('/:placa', vehiculoController.get);
export default vehiculo_routes;