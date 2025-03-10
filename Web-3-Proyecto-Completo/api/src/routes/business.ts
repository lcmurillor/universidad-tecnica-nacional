import { business_controller } from '../controller/business_controller';
import { Router } from "express";
import { business_type_controller } from '../controller/business_type_controller';
import { checkJwt } from '../middleware/jwt';
import { business_controller2 } from '../controller/business_controller2';

const bussinesRoutes = Router();

/**
 * Obtiene todos los business relacionados al id de un user que se encuentren registrados en la base de datos.
 */
 bussinesRoutes.get('/list', business_controller.getAllBusiness);

/**
 * Obtiene un solo business identificado por su respectivo id.
 */
 bussinesRoutes.get('/:id',[checkJwt],business_controller.getOneBusiness);

/**
 * Permite la creacion de un nuevo business, para esto debe enviar toda la informacion que se debe asociar al business.
 * Para la creaccion de un nuevo debe existir un user previamente registrado y un business_type. 
 */
// bussinesRoutes.post('/new',[checkJwt], business_controller.createBusiness);

bussinesRoutes.post('/new', business_controller2.createBusiness);

/**
 * Permite la actualizacion de un business previamente registrado en el sistema identificado por el id.
 * Este metodo posee limitaciones en cuanto a cuantos datos el usario puede eliminar de su business.
 */
bussinesRoutes.patch('/update/:id',[checkJwt], business_controller.updateBusiness);

/**
 * Permite eliminar un business previamente guardado en el sisteme identificandolo por si id.
 */
bussinesRoutes.patch('/delete/:id',[checkJwt], business_controller.deleteBusiness);


/**
 * Obtiene todos los business_type resgistrados en el sistema.
 */
bussinesRoutes.get('/type/list',[checkJwt], business_type_controller.getAllBusinessType);

export default bussinesRoutes;