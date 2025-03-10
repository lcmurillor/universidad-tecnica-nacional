import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { order_line } from "../entity/order_line";

export class order_line_controller{
    static getAll = async (req:Request, res:Response) => {
        const order_line_repo = getRepository(order_line);
    }

    static getOne = async (req:Request, res:Response) => {
        const order_line_repo = getRepository(order_line);
    }

    static save = async (req:Request, res:Response) => {
        const order_line_repo = getRepository(order_line);
    }

    static update = async (req:Request, res:Response) => {
        const order_line_repo = getRepository(order_line);
    }

    static delete = async (req:Request, res:Response) => {
        const order_line_repo = getRepository(order_line);
    }
}