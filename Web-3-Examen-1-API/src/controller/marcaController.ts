import { validate } from "class-validator";
import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { marca } from "../entity/marca";

export class marcaController {
    /**
     * Este metodo permite la creacion de nuevas marcas en la base de datos. Para eso es necesario indicar el nombre de la marca y si es metalizada o no, datos como el id se generan de manera automatica y el estado se asigna "true" por defecto. En caso de ocurrir agun error, el metodo no va a guadrar los datos he indicara cual fue el error.
     * @param req nombre, metalizado.
     * @param res Codigo de status justo con un mensaje.
     * @returns  Retorna un mensaje que indica si la marca se agrego correctamente o un mensaje que indique cual fue el error en caso de que un error se presente.
     */
    static save = async (req: Request, res: Response) => {
        const marcaRepo = getRepository(marca);
        const { nombre, metalizado } = req.body;
        if (!nombre) {
            return res.status(404).json({ mensaje: 'No ha ingresado el nombre de la marca.' });
        }
        if (metalizado == null) {
            return res.status(404).json({ mensaje: 'No ha indicado si la marca tiene metalizado.' });
        }
        if (await marcaRepo.findOne({ nombre: nombre })) {
            return res.status(400).json({ mensaje: 'La marca indicada corresponde a una marca ya resgistrada.' });
        }
        const _marca = new marca;
        _marca.nombre = nombre;
        _marca.metalizado = metalizado;
        _marca.estado = true;
        const validacion = { validationError: { target: false, value: false, children: false } };
        const errores = await validate(_marca, validacion);
        if (errores.length > 0) {
            return res.status(400).json(errores);
        }
        try {
            await marcaRepo.save(_marca);
        } catch (error) {
            return res.status(404).json({ mensaje: errores });
        }
        res.status(200).json({ mensaje: 'Marca guardadad.' });
    }

    /**
     * Este metodo permite la atualizacion de una marcas  previamente registrada en la base de datos. Para eso es necesario indicar el id y diendo del body el nombre de la marca y si es metalizada o no. El estado no se puede cambiar en este metodo. En caso de ocurrir agun error, el metodo no va a guadrar los datos he indicara cual fue el error.
     * @param req id
     * @param res  Codigo de status justo con un mensaje.
     * @returns Returna un mensaje que indica si la marca se actualizo correctamente o un mensaje que indique cual fue el error en caso de que un error se presente.
     */
    static update = async (req: Request, res: Response) => {
        const marcaRepo = getRepository(marca);
        const { id } = req.params;
        const { nombre, metalizado } = req.body;
        let _marca;
        if (!id) {
            return res.status(400).json({ mensaje: 'No a ingresado ningun id de marca.' });
        }
        try {
            _marca = await marcaRepo.findOneOrFail(id);
        } catch (error) {
            return res.status(404).json({ mensaje: 'El id de marca no corresponde a ninguna marca.' });
        }
        if (nombre) {
            _marca.nombre = nombre;
        }
        if (!(metalizado == null)) {
            _marca.metalizado = metalizado;
        }
        const validacion = { validationError: { target: false, value: false, children: false } };
        const errores = await validate(_marca, validacion);
        if (errores.length > 0) {
            return res.status(400).json(errores);
        }
        try {
            await marcaRepo.save(_marca);
        } catch (error) {
            return res.status(404).json({ mensaje: errores });
        }
        res.status(200).json({ mensaje: 'Marca actualizada.' });
    }

    /**
     * Este metodo permite la eliminacion de una marcas  previamente registrada en la base de datos. Para eso es necesario indicar el id. El estado pasara a ser "false". Si la marca indica por el id no corresponde a ninguna marca en el sistema o es el id de una marca ya eliminada el sistema lo mostrara en un mensaje.
     * @param req id.
     * @param res Codigo de status justo con un mensaje.
     * @returns Retorna un mensaje que indica si la marca se elimino correctamente o un mensaje que indique cual fue el error en caso de que un error se presente.
     */
    static delete = async (req: Request, res: Response) => {
        const marcaRepo = getRepository(marca);
        const { id } = req.params;
        let _marca;
        if (!id) {
            return res.status(400).json({ mensaje: 'No a indicado el id de la marca.' });
        }
        try {
            _marca = await marcaRepo.findOneOrFail(id);
            if (!_marca.estado) {
                return res.status(400).json({ mensaje: 'la marca ya habia sido eliminada.' });
            }
        } catch (error) {
            return res.status(404).json({ mensaje: 'El Id indicado no corresponde a ninguna marca.' });
        }
        _marca.estado = false;
        try {
            await marcaRepo.save(_marca);
        } catch (error) {
            return res.status(404).json({ mensaje: 'Error al eliminar la marca.' });
        }
        res.status(200).json({ mensaje: 'Marca eliminada.' });
    }

    /**
     * Permite mostrar el nombre y si la marca indicada disponde de metalizado o no, para eso es necesario indicar la marca mediante un id. Si el id no corresponde a ninguna marca, o la marca indicada esta eliminada, no se mostrara ningun dato y retornara el error.
     * @param req id.
     * @param res nombre, metalizado de la marca indicada mediante el id.
     * @returns Retorna archivo json con la informacion de la marca indicada o un mensaje que indique cual fue el error en caso de que un error se presente.
     */
    static get = async (req: Request, res: Response) => {
        const marcaRepo = getRepository(marca);
        const { id } = req.params;
        let _marca;
        if (!id) {
            return res.status(400).json({ mensaje: 'El id indicado no correspode a ninguna marca.' });
        }
        try {
            _marca = await marcaRepo.findOneOrFail({
                select: ['nombre', 'metalizado'], where: { id: id, estado: true }
            });
        } catch (error) {
            return res.status(404).json({ mensaje: 'Error al mostrar la marca. La marca no existe o corresponde a una marca eliminada.' });
        }
        return res.send(_marca);
    }

    /**
     * Permite mostrar el nombre y si la marca disponde de metalizado o no. Solo muestra las marcas con estados activos.
     * @param req 
     * @param res nombre, metalizado.
     * @returns Retorna archivo json con la informacion de la marca indicada o un mensaje que indique cual fue el error en caso de que un error se presente.
     */
    static getAll = async (req: Request, res: Response) => {
        const marcaRepo = getRepository(marca);
        let _marca;
        try {
            _marca = await marcaRepo.find({
                select: ['nombre', 'metalizado'], where: { estado: true }
            });
            return res.send(_marca);
        } catch (error) {
            return res.status(404).json({ mensaje: 'Error al mostrar la marca. La marca no existe o corresponde a una marca eliminada.' });
        }
    }
}
