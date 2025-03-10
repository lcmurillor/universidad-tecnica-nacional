import { validate } from "class-validator";
import { Request, Response } from "express"
import { getRepository } from "typeorm"
import { review } from "../entity/review"
import { user } from "../entity/user";

export class review_controller{
    static getAll = async (req:Request, res:Response) => {
        const review_repo = getRepository(review);
    }

    //Funcion que obtiene todas las Reviews de un Restuarante o un Repartidor
    static getReviews = async (req:Request, res:Response) => {
        const review_repo = getRepository(review);
        const { id, type } = req.params;
        let reviews;

        if (!id){
            return res.status(401).json({mensaje: 'Ingrese el ID del Restaurante o Repartidor'});
        }

        if (!type){
            return res.status(401).json({mensaje: 'Ingrese el tipo de Review'});
        }

        try {
            reviews = await review_repo.find({
                select: [
                    'calification',
                    'comment'
                ],
                where: {business_delivery_id: id, type: type}
            });
        } catch (error) {
            return res.status(404).json({mensaje: 'Reviews no Encontradas'});
        }

        return res.send(reviews);
    }

    static save = async (req:Request, res:Response) => {
        const review_repo = getRepository(review);
        const user_repo = getRepository(user);
        const {
            calification,
            comment,
            type,
            user_id,
            business_delivery_id
        } = req.body;
        const reviews = new review();
        let users;

        if (!calification){
            return res.status(401).json({mensaje: 'Ingrese la Clasificación'});
        }

        if (!comment){
            return res.status(401).json({mensaje: 'Ingrese el comentario'});
        }

        if (!type){
            return res.status(401).json({mensaje: 'Ingrese la tipo de Review'});
        }

        if (!business_delivery_id){
            return res.status(401).json({mensaje: 'Ingrese el Id del Restaurante o Repartidor'});
        }

        if (!user_id){
            return res.status(401).json({mensaje: 'Ingrese el id del Usuario'});
        }

        try {
            users = await user_repo.findOneOrFail(user_id)
        } catch (error) {
            return res.status(404).json({mensaje: 'Usuario no Encontrado'});
        }

        reviews.calification = calification;
        reviews.comment = comment;
        reviews.type = type;
        reviews.user = users;
        reviews.business_delivery_id = business_delivery_id;
        reviews.created_at = new Date().toLocaleString();
        reviews.updated_at = new Date().toLocaleString();

        const validate_options = { validationError: { target: false, value: false, children: false}};
        const errors = await validate(reviews, validate_options);

        if (errors.length > 0){
            return res.status(400).json(errors);
        }

        try {
            await review_repo.save(reviews);
        } catch (error) {
            return res.status(404).json({mensaje: 'Reseña no Registrada'});
        }

        return res.status(200).json({Mensaje: 'La Reseña se ha registrado satisfatoriamente'});

    }

    static update = async (req:Request, res:Response) => {
        const review_repo = getRepository(review);
        const { id } =  req.params;
        const {
            calification,
            comment,
            type,
            business_delivery_id
        } = req.body;
        let reviews;

        if (!calification){
            return res.status(401).json({mensaje: 'Ingrese El id de la Reseña'});
        }

        if (!calification){
            return res.status(401).json({mensaje: 'Ingrese la Clasificación'});
        }

        if (!comment){
            return res.status(401).json({mensaje: 'Ingrese el comentario'});
        }

        if (!type){
            return res.status(401).json({mensaje: 'Ingrese la tipo de Review'});
        }

        if (!business_delivery_id){
            return res.status(401).json({mensaje: 'Ingrese el Id del Restaurante o Repartidor'});
        }

        try {
            reviews = await review_repo.findOneOrFail(id);
        } catch (error) {
            return res.status(404).json({mensaje: 'Reseña no Encontrado'});
        }

        reviews.calification = calification;
        reviews.comment = comment;
        reviews.type = type;
        reviews.business_delivery_id = business_delivery_id;
        reviews.updated_at = new Date().toLocaleString();

        const validate_options = { validationError: { target: false, value: false, children: false}};
        const errors = await validate(reviews, validate_options);

        if (errors.length > 0){
            return res.status(401).json(errors);
        }

        try {
            await review_repo.save(reviews);
        } catch (error) {
            return res.status(404).json({mensaje: 'Reseña no ACtualizada'});
        }

        return res.status(200).json({mensaje: 'La Reseña se ha actializado satisfatoriamente'});
    }

    static delete = async (req:Request, res:Response) => {
        const reviewRepo = getRepository(review);
    }
}