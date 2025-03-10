import { Router } from "express";
import marca from "./marca";
import vehiculo from "./vehiculo";


const index_routes = Router();
/**
 * Conexion de la API para todas las rutas que corresponde a vehiculo.
 */
index_routes.use("/vehiculo",vehiculo);

/**
 * Conexion de la API para todas las rutas que corresponde a marca.
 */
index_routes.use("/marca",marca);


export default index_routes;