import { address } from './../entity/address';
import { Request, Response } from "express";
import { getManager, getRepository } from "typeorm";
import { user } from '../entity/user';
import { district } from '../entity/district';
import { canton } from '../entity/canton';
import { province } from '../entity/province';
import { validate } from 'class-validator';

export class address_controller{

    static getUserAddress = async (req:Request, res:Response) => {
        const user_repo = getRepository(user);
        const { id } = req.params;
        let _user;

        if (!id){
            return res.status(401).json({mensaje: "Ingrese el Id del Usuario"});
        }

        try {
            _user =  await user_repo.findOneOrFail(id);
        } catch (error) {
            return res.status(404).json({mensaje: "Usuario no Encontrado"});
        }

        try {
            let _address = await getManager().createQueryBuilder(address, "a")
                .innerJoin(district, 'd', 'd.id = a.district.id')
                .innerJoin(canton, 'c', 'c.id = d.cantonId')
                .innerJoin(province, 'p', 'p.id = c.provinceId')
                .innerJoin(user, 'u', `u.Id = a.userId AND u.Id = ${_user.Id}`)
                .select('a.title', 'title')
                .addSelect('p.name', 'province')
                .addSelect('c.name', 'canton')
                .addSelect('d.name', 'district')
                .addSelect('a.details', 'details')
                .getRawMany();
            return res.send(_address);
        } catch (error) {
            return res.status(404).json({mensaje: "Dirección no Encontrada"});
        }
    }

    static getOne = async (req:Request, res:Response) => {
        const { id } = req.params;

        if (!id){
            return res.status(401).json({mensaje: "Ingrese el Id del Dirección"});
        }

        try {
            let _address = await getManager().createQueryBuilder(address, "a")
                .innerJoin(district, 'd', `d.id = a.district.id AND a.id = ${id}`)
                .innerJoin(canton, 'c', 'c.id = d.cantonId')
                .innerJoin(province, 'p', 'p.id = c.provinceId')
                .select('a.title', 'title')
                .addSelect('p.name', 'province')
                .addSelect('c.name', 'canton')
                .addSelect('d.name', 'district')
                .addSelect('a.details', 'details')
                .where('a.state = "A"')
                .getRawMany();
            return res.send(_address);
        } catch (error) {
            return res.status(404).json({mensaje: "Dirección no Encontrada"});
        }
    }

    static save = async (req:Request, res:Response) => {
        const address_repo = getRepository(address);
        const user_repo = getRepository(user);
        const district_repo = getRepository(district);
        const {
            title,
            details,
            district_id,
            user_id
        } = req.body;
        const _address = new address;
        let _user, _district;

        if (!title){
            return res.status(401).json({mensaje: 'Ingrese el Titulo para la dirección'});
        }
        if (!details){
            return res.status(401).json({mensaje: 'Ingrese los detalles de la dirección'});
        }
        if (!district_id){
            return res.status(401).json({mensaje: 'Ingrese el id del Distrito de la direción'});
        }
        if (!user_id){
            return res.status(401).json({mensaje: 'Ingrese el Id del Ususario'});
        }

        try {
            _user = await user_repo.findOneOrFail(user_id)
        } catch (error) {
            return res.status(404).json({mensaje: 'Usuario no Encontrado'});
        }

        try {
            _district = await district_repo.findOneOrFail(district_id)
        } catch (error) {
            return res.status(404).json({mensaje: 'Distrito no Encontrado'});
        }

        _address.title = title;
        _address.details = details;
        _address.state = "A";
        _address.created_at = new Date().toLocaleString();
        _address.updated_at = new Date().toLocaleString();
        _address.district = _district;
        _address.user = _user;

        const validate_options = { validationError: { target: false, value: false, children: false}};
        const errors = await validate(_address, validate_options);

        if (errors.length > 0){
            return res.status(401).json(errors);
        }

        try {
            await address_repo.save(_address);
        } catch (error) {
            return res.status(404).json({mensaje: 'Dirección no Registrada'});
        }

        return res.status(200).json({mensaje: 'La Dirección se ha registrado satisfatoriamente'});
    }

    static update = async (req:Request, res:Response) => {
        const address_repo = getRepository(address);
        const district_repo = getRepository(district);
        const { id } = req.params;
        const {
            title,
            details,
            district_id,
            state
        } = req.body;
        let _address, _district;

        if (!id){
            return res.status(401).json({mensaje: 'Ingrese el id de la dirección'});
        }
        if (!title){
            return res.status(401).json({mensaje: 'Ingrese el Titulo para la direción'});
        }
        if (!details){
            return res.status(401).json({mensaje: 'Ingrese los detalles de la dirección'});
        }
        if (!district_id){
            return res.status(401).json({mensaje: 'Ingrese el id del Distrito de la direción'});
        }
        if (!state){
            return res.status(401).json({mensaje: 'Ingrese el estado de la direción'});
        }

        try {
            _address = await address_repo.findOneOrFail(id)
        } catch (error) {
            return res.status(404).json({mensaje: 'Dirección no Encontrado'});
        }

        try {
            _district = await district_repo.findOneOrFail(district_id)
        } catch (error) {
            return res.status(404).json({mensaje: 'Distrito no Encontrado'});
        }

        _address.title = title;
        _address.details = details;
        _address.state = state;
        _address.updated_at = new Date().toLocaleString();
        _address.district = _district;

        const validate_options = { validationError: { target: false, value: false, children: false}};
        const errors = await validate(_address, validate_options);

        if (errors.length > 0){
            return res.status(401).json(errors);
        }

        try {
            await address_repo.save(_address);
        } catch (error) {
            return res.status(404).json({mensaje: 'Dirección no Actualizada'});
        }

        return res.status(200).json({mensaje: 'La Dirección se ha actualizado satisfatoriamente'});
    }

    static delete = async (req:Request, res:Response) => {
        const address_repo = getRepository(address);
        const { id } = req.params;
        let _address;

        if (!id){
            return res.status(401).json({mensaje: 'Ingrese el id de la dirección'});
        }

        try {
            _address = await address_repo.findOneOrFail(id)
        } catch (error) {
            return res.status(404).json({mensaje: 'Dirección no Encontrado'});
        }

        _address.state = "D";

        try {
            await address_repo.save(_address);
        } catch (error) {
            return res.status(404).json({mensaje: 'Dirección no Eliminado'});
        }

        return res.status(200).json({mensaje: 'La Dirección se ha eliminado satisfatoriamente'});
    }
}