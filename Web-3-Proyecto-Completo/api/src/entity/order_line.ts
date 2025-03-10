import { IsDate, IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity, ManyToOne, PrimaryGeneratedColumn } from "typeorm";
import { order } from "./order";
import { product } from "./product";

@Entity()
export class order_line {
    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty()
    amount: number;

    @Column() @IsNotEmpty() @MaxLength(1)
    category: string;

    @Column() @IsNotEmpty()
    price: number;

    @Column() @IsNotEmpty() @MaxLength(10) @IsDate()
    created_at: string;

    @Column() @IsNotEmpty() @IsDate()
    updated_at: string;

    @ManyToOne(type => product, product => product.order_line)
    product: product;

    @ManyToOne(type => order, order => order.order_line)
    order: order;
}