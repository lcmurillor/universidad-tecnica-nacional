import { validate } from "class-validator";
import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { color } from "../entity/color";
import { marca } from "../entity/marca";
import { tipo_vehiculo } from "../entity/tipo_vehiculo";
import { vehiculo } from "../entity/vehiculo";

export class vehiculoController {
    /**
     * Este metodo permite la crecion de un nuevo vehiculo en la base de datos. Para esto es necesario indicar placa, el id marca, el id color, el cilindraje, el id tipo de vehiculo, la cantidad de pasajeros y la fecha ingreso. El id se genera de manera autimatica y el estado es "true" por defacto. En caso de que algun valor obligatorio haga falta el sistema va a devolver el error y no va a guardar nada. Tampoco se pueden guardar vehiculos con marcas, colores o tipos de veniculos que no se encuentren en el sistema o que esten eliinados.
     * @param req placa, id_marca, id_color, cilindraje, id_TipoVehiculo, cantidadPasajeros, fecha_ingreso
     * @param res Codigo de status justo con un mensaje.
     * @returns Retorna un mensaje que indica si el vehiculo se agrego correctamente o un mensaje que indique cual fue el error en caso de que un error se presente.
     */
    static save = async (req: Request, res: Response) => {
        const vehiculoRepo = getRepository(vehiculo);
        const { placa, id_marca, id_color, cilindraje, id_TipoVehiculo, cantidadPasajeros, fecha_ingreso } = req.body;
        //Validacion de entrada de datos.
        if (!placa) {
            return res.status(404).json({ mensaje: 'No ha ingresado el placa del vehiculo.' });
        }
        if (!id_marca) {
            return res.status(404).json({ mensaje: 'No ha ingresado la marca del vehiculo.' });
        }
        if (!id_color) {
            return res.status(404).json({ mensaje: 'No ha ingresado el color del vehiculo.' });
        }
        if (!cilindraje) {
            return res.status(404).json({ mensaje: 'No ha ingresado el cilindraje del vehiculo.' });
        }
        if (!id_TipoVehiculo) {
            return res.status(404).json({ mensaje: 'No ha ingresado el tipo de vehiculo del vehiculo.' });
        }
        if (!cantidadPasajeros) {
            return res.status(404).json({ mensaje: 'No ha ingresado la cantidad de psajeros del vehiculo.' });
        }
        if (!fecha_ingreso) {
            return res.status(404).json({ mensaje: 'No ha ingresado la fecha de ingreso del vehiculo.' });
        }
        //Validacion de ids.
        const marcaRepo = getRepository(marca);
        try {
            await marcaRepo.findOneOrFail({ estado: true, id: id_marca });
        } catch (error) {
            return res.status(404).json({ mensaje: 'El Id de marca indicado no corresponde a ninguna marca o la marca esta eliminada.' });
        }
        const colorRepo = getRepository(color);
        try {
            await colorRepo.findOneOrFail({ estado: true, id: id_color });
        } catch (error) {
            return res.status(404).json({ mensaje: 'El Id de color indicado no corresponde a ninguna color o el color esta eliminado.' });
        }
        const tipoVehiculoRepo = getRepository(tipo_vehiculo);
        try {
            await tipoVehiculoRepo.findOneOrFail({ estado: true, id: id_TipoVehiculo });
        } catch (error) {
            return res.status(400).json({ mensaje: 'El Id de tipo de vehiculo indicado no corresponde a ninguna Tipo de vehiculo o el tipo de veiculo esta eliminado.' });
        }
        //Validacion de placa.
        if (await vehiculoRepo.findOne({ placa: placa })) {
            return res.status(400).json({ mensaje: 'La placa indicada corresponde a un vehiculo ya resgistrado.' });
        }
        //Validacion de fecha.
        let _fechahoy = new Date().toLocaleDateString()
        if (new Date(_fechahoy) < new Date(fecha_ingreso)) {
            return res.status(400).json({ mensaje: 'La fecha de ingreso es superior a la fecha actual.' });
        }

        const _vehiculo = new vehiculo;
        _vehiculo.placa = placa;
        _vehiculo.id_marca = id_marca;
        _vehiculo.id_color = id_color;
        _vehiculo.cilindraje = cilindraje;
        _vehiculo.id_TipoVehiculo = id_TipoVehiculo;
        _vehiculo.cantidadPasajeros = cantidadPasajeros;
        _vehiculo.fecha_ingreso = new Date(fecha_ingreso);
        _vehiculo.estado = true;
        const validacion = { validationError: { target: false, value: false, children: false } };
        const errores = await validate(_vehiculo, validacion);
        if (errores.length > 0) {
            return res.status(400).json(errores);
        }
        try {
            await vehiculoRepo.save(_vehiculo);
        } catch (error) {
            return res.status(404).json({ mensaje: errores });
        }
        res.status(200).json({ mensaje: 'Vehiculo guardadad.' });
    }

    /**
     * Este metodo permite obtener la placa, la marca, el color, el cilindriaje, el tipo de vehiculo, la cantidad de pasajeros y la fecha de ingreso de un vehiculo, indicando este mediante su placa. En caso de que el vehiculo no se encuentre en la base de datos o este eliminado, no se mostrara ningun dato y retornara el error.
     * @param req placa 
     * @param res placa, marca, color, cilindraje, tipo_vehiculo, cantidadPasajeros, Fecha_ingreso.
     * @returns Retorna archivo json con la informacion de del vehiculo indicada, para esto realiza un inner join con las demas tablas para peresentar los datos de maenra facil de leer o un mensaje que indique cual fue el error en caso de que un error se presente.
     */
    static get = async (req: Request, res: Response) => {
        const vehiculoRepo = getRepository(vehiculo);
        const { placa } = req.params;
        let _vehiculo;
        if (!placa) {
            return res.status(400).json({ mensaje: 'La placa indicada no correspode a ninguna vehiculo.' });
        }
        try {
            _vehiculo = await vehiculoRepo.query(`select v.placa, m.nombre as 'marca', c.nombre as 'color', v.cilindraje, t.nombre as 'tipo_vehiculo', v.cantidadPasajeros, v.fecha_ingreso from vehiculo as v 
            inner join marca as m on m.id = v.idMarcaId
            inner join color as c on c.id = v.idColorId
            inner join tipo_vehiculo as t on t.id = v.idTipoVehiculoId
            where v.estado = true && v.placa = `+ placa + `;`);
        } catch (error) {
            return res.status(404).json({ mensaje: 'Error al mostrar le vehiculo. El vehiculo no existe o corresponde a una vehiculo eliminada.' });
        }
        return res.send(_vehiculo);
    }

    /**
     * ste metodo permite la eliminacion de un vehiculo previamente registrada en la base de datos. Para eso es necesario indicar la placa. El estado pasara a ser "false". Si el vehiculo indica por la placa no corresponde a ningun vehiculo en el sistema o es la placa de un vehiculo ya eliminado el sistema lo mostrara en un mensaje.
     * @param req placa
     * @param res Codigo de status justo con un mensaje.
     * @returns Retorna un mensaje que indica si el vehiculo se elimino correctamente o un mensaje que indique cual fue el error en caso de que un error se presente.
     */
    static delete = async (req: Request, res: Response) => {
        const vehiculoRepo = getRepository(vehiculo);
        const { placa } = req.params;
        let _vehiculo;
        if (!placa) {
            return res.status(400).json({ mensaje: 'No a indicado la placa del vehiculo.' });
        }
        try {
            _vehiculo = await vehiculoRepo.findOneOrFail({ where: { placa: placa } });
            if (!_vehiculo.estado) {
                return res.status(400).json({ mensaje: 'El veiculo ya habia sido eliminado.' });
            }
        } catch (error) {
            return res.status(404).json({ mensaje: 'La placa indicada no corresponde a ningun vehiculo.' });
        }
        _vehiculo.estado = false;
        try {
            await vehiculoRepo.save(_vehiculo);
        } catch (error) {
            return res.status(404).json({ mensaje: 'Error al eliminar el vehiculo.' });
        }
        res.status(200).json({ mensaje: 'Vehiculo eliminada.' });
    }
}