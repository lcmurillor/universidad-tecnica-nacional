import { validate } from "class-validator";
import { Request, Response } from "express";
import { getManager, getRepository } from "typeorm";
import { business } from "../entity/business";
import { phone } from "../entity/phone";
import { photo } from "../entity/photo";
import { user } from "../entity/user";

export class business_controller {

    /**
     * Permite la optencion de un business identificado mediante el id.
     * Retorna todos los valores de acceso publico del business.
     * Ejecuta sus respectivos controles y validaciones de los datos optenidos y los datos que devuelve.
     * en caso de presntar errores, retorna un mensaje de error con una descripcion breve del prblema.
     * @param req Id del business.
     * @param res nome, address, open_time, close_time, Business_type, phone, photo.
     */
    static async getOneBusiness(req: Request, res: Response) {
        const {id} = req.params;
        if (!id) {
            return res.status(400).json({ mensaje: "No ha indicado ningún negocio." });
        }
        try {
            let _business = await getRepository(business).query(`select b.name, b.address, b.open_time, b.close_time,
            t.number as 'phone_number', 
            i.name as 'photo_name', 
            bt.name as 'type_business_name',
            u.full_name as 'user_full_name',
            u.email as 'user_email',
            u.phone as 'user_phone',
            u.photo as 'user_photo'
            from business as b
            inner join phone as t on t.businessId = b.id
            inner join photo as i on i.businessId = b.id
            inner join business_type as bt on bt.id = b.businessTypeId
            inner join user as u on u.id = b.userId
            where b.status = 'A' and b.id=`+id);
            return res.send(_business);
        } catch (error) {
            return res.status(404).json({mensaje: "Ha ocurrido un error al intentar mostrar la lista de negocios."});
        }
    }
    /**
     * Permite la optencion de todos los business registrados en la base de datos.
     * Retorna todos los valores de acceso publico de los business.
     * Ejecuta sus respectivos controles y validaciones de los datos optenidos y los datos que devuelve.
     * en caso de presntar errores, retorna un mensaje de error con una descripcion breve del prblema.
     * @param req 
     * @param res  Codigo de status justo con un mensaje.
     * @returns Todos los datos de business con sus phones y photos.
     */
    static async getAllBusiness(req: Request, res: Response) {
        
        try {
            let _business = await getRepository(business).query(`select b.id,b.name, b.address, b.open_time, b.close_time,
            t.number as 'phone_number', 
            i.name as 'photo_name', 
            bt.name as 'type_business_name',
            u.full_name as 'user_full_name',
            u.email as 'user_email',
            u.phone as 'user_phone',
            u.photo as 'user_photo'
            from business as b
            inner join phone as t on t.businessId = b.id
            inner join photo as i on i.businessId = b.id
            inner join business_type as bt on bt.id = b.businessTypeId
            inner join user as u on u.id = b.userId
            where b.status = 'A'`);
            return res.send(_business);
        } catch (error) {
            return res.status(404).json({mensaje: "Ha ocurrido un error al intentar mostrar la lista de negocios."});
        }
    }

    /**
     * Permite la creacion de nuevos business y la incercion de los mismos en la base de datos.
     * Es necesario todos los datos para la creacion de un business, junto con otros datos que ya deven existir en la base de datos
     * como user y business_type para su correcta insercion.
     * Ejecuta sus respectivos controles y validaciones de los datos optenidos y los datos que devuelve.
     * en caso de presntar errores, retorna un mensaje de error con una descripcion breve del prblema.
     * @param req identity, name, address, open_time, close_time, user, business_type, tel, img.
     * @param res Codigo de status justo con un mensaje.
     * @returns Mensaje que indica si la insercion se ejecito correctamente o un mensaje que indique cual fue el error.
     */
    static async createBusiness(req: Request, res: Response) {
        const business_repo = getRepository(business);
        const { identity, name, address, open_time, close_time, user, business_type, tel, img } = req.body;
        //VALIDACION de existencia de datos.
        if (!identity) {
            return res.status(404).json({ mensaje: "No indicó la cédula juríduca del negocio." });
        } else if (!name) {
            return res.status(404).json({ mensaje: "No indicó el nombre del negocio." });
        } else if (!address) {
            return res.status(404).json({ mensaje: "No indicó la direción del negocio." });
        } else if (!close_time) {
            return res.status(404).json({ mensaje: "No indicó la hora de cierre del negocio." });
        } else if (!open_time) {
            return res.status(404).json({ mensaje: "No indicó la hora de apertura del negocio." });
        } else if (!user) {
            return res.status(404).json({ mensaje: "El usuario no está identificado." });
        } else if (!business_type) {
            return res.status(404).json({ mensaje: "El tipo de negocio no está identificado." });
        } else if (!tel) {
            return res.status(404).json({ mensaje: "No indicó nigún telefono del negocio." });
        } else if (!img) {
            return res.status(404).json({ mensaje: "No cargó ninguna foto del negocio." });
        }
        //CREACION del business.
        const _business = new business;
        let _date = new Date;
        _business.identity = identity;
        _business.name = name;
        _business.address = address;
        _business.open_time = open_time;
        _business.close_time = close_time;
        _business.user = user;
        _business.business_type = business_type;
        _business.created_at = _date.toString();
        _business.updated_at = _date.toString();
        _business.status = "A";
        //VALIDACION de errores en business.
        const validateOptions = { validationError: { target: false, value: false, children: false } };
        const mistakes = await validate(_business, validateOptions);
        if (mistakes.length > 0) {
            return res.status(400).json(mistakes);
        }
        //INCERSION de business en la base de datos. 
        try {
            await business_repo.save(_business);
        } catch (error) {
            return res.status(404).json({ mensaje: "Error al intentar guardar el negocio en la base de datos, revise los datos ingresados." });
        }
        const photo_repo = getRepository(photo);
        try {
            for (let index = 0; index < img.length; index++) {
                //CREACION de las photos.
                const _photo = new photo;
                _photo.name = img[index];
                _photo.business = _business;
                _photo.created_at = _date.toString();
                _photo.updated_at = _date.toString()
                //VALIDACION de errores en photo.
                const validateOptions = { validationError: { target: false, value: false, children: false } };
                const mistakes = await validate(_photo, validateOptions);
                if (mistakes.length > 0) {
                    return res.status(400).json(mistakes);
                }
                //INCERSION de photo en la base de datos.
                await photo_repo.save(_photo);
            }
        } catch (error) {
            return res.status(404).json({ mensaje: "Error al intentar guardar la foto/fotos en la base de datos, revise los datos ingresados." });
        }
        const phone_repo = getRepository(phone);
        try {
            for (let index = 0; index < tel.length; index++) {
                //CREACION de las phones.
                const _phone = new phone;
                _phone.number = tel[index];
                _phone.business = _business;
                _phone.created_at = _date.toString();
                _phone.updated_at = _date.toString();
                //VALIDACION de errores en phone.
                const validateOptions = { validationError: { target: false, value: false, children: false } };
                const mistakes = await validate(_phone, validateOptions);
                //INCERSION de phone en la base de datos.
                await phone_repo.save(_phone);
            }
        } catch (error) {
            return res.status(404).json({ mensaje: "Error al intentar guardar el telefono/telefonos en la base de datos, revise los datos ingresados." });
        }
        res.status(201).json({ mensaje: "El negocio se a creado de manera exitosa." });
    }


    /**
     * Permite la actualizacion de un business registrado en la base de datos identificada por el id.
     * Si el id optenido no corresponde a nigún business el sistema retorna una indicacioón.
     * Los datos que se puede actualizar de un business son distintos a los datos solicitados para su creación.
     * Ejecuta sus respectivos controles y validaciones de los datos optenidos y los datos que devuelve.
     * en caso de presntar errores, retorna un mensaje de error con una descripcion breve del prblema.
     * @param req id, name, address, open_time, close_time, business_type, tel_deleted, tel_new, img_deleted, img_new
     * @param res Codigo de status justo con un mensaje.
     * @returns Mensaje que indica si la actualizacion se ejecito correctamente o un mensaje que indique cual fue el error.
     */
    static async updateBusiness(req: Request, res: Response) {
        const business_repo = getRepository(business);
        const { name, address, open_time, close_time, business_type, tel_deleted, tel_new, img_deleted, img_new } = req.body;
        const { id } = req.params;
        let _business;
        //VALIDACION de existencia de datos.
        if (!id) {
            return res.status(404).json({ mensaje: "El negocio no fue identificado." });
        }
        try {
            _business = await business_repo.findOneOrFail(id);
        } catch (error) {
            return res.status(404).json({ mensaje: "El negocio indicado no existe en el sistema." });
        }
        //ACTUALIZACION del business.
        if (name) {
            _business.name = name;
        }
        if (address) {
            _business.address = address;
        }
        if (close_time) {
            _business.close_time = close_time;
        }
        if (open_time) {
            _business.open_time = open_time;
        }
        if (business_type) {
            _business.business_type = business_type;
        }
        let _date = new Date;
        _business.updated_at = _date.toString();
        //VALIDACION de errores en business.
        const validateOptions = { validationError: { target: false, value: false, children: false } };
        const mistakes = await validate(_business, validateOptions);
        if (mistakes.length > 0) {
            return res.status(400).json(mistakes);
        }
        //ACTUALIZACION de business en la base de datos. 
        try {
            await business_repo.save(_business);
        } catch (error) {
            return res.status(404).json({ mensaje: "Error al intentar actualizar el negocio en la base de datos, revise los datos ingresados." });
        }
        //VALIDACION de existencia de datos.
        if (img_deleted || img_new) {
            const photo_repo = getRepository(photo);
            if (img_deleted) {
                //ELIMINACION de photo en la base de datos.
                try {
                    for (let index = 0; index < img_deleted.length; index++) {
                        let _photo = await photo_repo.findOneOrFail({ where: { name: img_deleted[index] } });
                        await photo_repo.delete(_photo)
                        //VALIDACION de errores en photo.
                        const validateOptions = { validationError: { target: false, value: false, children: false } };
                        const mistakes = await validate(img_deleted, validateOptions);
                        if (mistakes.length > 0) {
                            return res.status(400).json(mistakes);
                        }
                    }
                } catch (error) {
                    return res.status(404).json({ mensaje: "Error al intentar eliminar la foto/fotos en la base de datos, revise los datos ingresados." });
                }
            }
            if (img_new) {
                //INSERCION de nuevas photo.
                try {
                    for (let index = 0; index < img_new.length; index++) {
                        //CREACION de las photos.
                        const _photo = new photo;
                        _photo.name = img_new[index];
                        _photo.business = _business;
                        _photo.created_at = _date.toString();
                        _photo.updated_at = _date.toString()
                        //VALIDACION de errores en photo.
                        const validateOptions = { validationError: { target: false, value: false, children: false } };
                        const mistakes = await validate(_photo, validateOptions);
                        if (mistakes.length > 0) {
                            return res.status(400).json(mistakes);
                        }
                        //INCERSION de photo en la base de datos.
                        await photo_repo.save(_photo);
                    }
                } catch (error) {
                    return res.status(404).json({ mensaje: "Error al intentar guardar la foto/fotos en la base de datos, revise los datos ingresados." });
                }
            }

        }
        //VALIDACION de existencia de datos.
        if (tel_deleted || tel_new) {
            const phone_repo = getRepository(phone);
            if (tel_deleted) {
                //ELIMINACION de phone en la base de datos.
                try {
                    for (let index = 0; index < tel_deleted.length; index++) {
                        let _phone = await phone_repo.findOneOrFail({ where: { number: tel_deleted[index] } });
                        await phone_repo.delete(_phone)
                        //VALIDACION de errores en phone.
                        const validateOptions = { validationError: { target: false, value: false, children: false } };
                        const mistakes = await validate(tel_deleted, validateOptions);
                        if (mistakes.length > 0) {
                            return res.status(400).json(mistakes);
                        }
                    }
                } catch (error) {
                    return res.status(404).json({ mensaje: "Error al intentar eliminar el telefono/telefonos en la base de datos, revise los datos ingresados." });
                }
            }
            if (tel_new) {
                //INSERCION de nuevas phone.
                try {
                    for (let index = 0; index < tel_new.length; index++) {
                        //CREACION de los phone.
                        const _phone = new phone;
                        _phone.number = tel_new[index];
                        _phone.business = _business;
                        _phone.created_at = _date.toString();
                        _phone.updated_at = _date.toString()
                        //VALIDACION de errores en phone.
                        const validateOptions = { validationError: { target: false, value: false, children: false } };
                        const mistakes = await validate(_phone, validateOptions);
                        if (mistakes.length > 0) {
                            return res.status(400).json(mistakes);
                        }
                        //INCERSION de phone en la base de datos.
                        await phone_repo.save(_phone);
                    }
                } catch (error) {
                    return res.status(404).json({ mensaje: "Error al intentar guardar el telefono/telefonos en la base de datos, revise los datos ingresados." });
                }
            }
        }

        res.status(201).json({ mensaje: "El negocio se a actualizado de manera exitosa." });
    }

    /**
     * La eliminacion de business se realiza de manera logica, por lo tanto esel cambio de estado de "Activo" a "Inactivo".
     * Ejecuta sus respectivos controles y validaciones de los datos optenidos y los datos que devuelve.
     * en caso de presntar errores, retorna un mensaje de error con una descripcion breve del prblema.
     * @param req id
     * @param res Codigo de status justo con un mensaje.
     * @returns Mensaje que indica si la actualizacion se ejecito correctamente o un mensaje que indique cual fue el error.
     */
    static async deleteBusiness(req: Request, res: Response) {
        const business_repo = getRepository(business);
        const { id } = req.params;
        let _business;
        if (!id) {
            return res.status(400).json({ mensaje: "No ha indicado ningún negocio." });
        }
        try {
            _business = await business_repo.findOneOrFail(id);

        } catch (error) {
            return res.status(404).json({ mensaje: "El negocio indicado no existe en el sistema." });
        }
        _business.status = "I";
        try {
            await business_repo.save(_business);
        } catch (error) {
            return res.status(404).json({ mensaje: "Ha ocurrido un error al eliminar el negocio del sistema." });
        }
        res.status(200).json({ mensaje: "El negocio se a eliminado de manera exitosa." });
    }

}