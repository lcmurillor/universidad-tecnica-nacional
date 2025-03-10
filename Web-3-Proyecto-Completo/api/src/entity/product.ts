import { IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity, ManyToOne, OneToMany, PrimaryGeneratedColumn } from "typeorm";
import { order_line } from "./order_line";
import { product_category } from "./product_category";
import { business } from "./business";

@Entity()
export class product {

    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty() @MaxLength(50)
    name: string;

    @Column() @IsNotEmpty() @MaxLength(250)
    description: string;

    @Column() @IsNotEmpty() @MaxLength(250)
    photo: string;

    @Column() @IsNotEmpty()
    price: number;

    @Column() @IsNotEmpty()
    discount: number;

    @Column() @IsNotEmpty() @MaxLength(1)
    offert_state: string;

    @Column() @IsNotEmpty() @MaxLength(1)
    state: string;

    @Column() @IsNotEmpty()
    comment: string;

    @Column() @IsNotEmpty() 
    created_at: string;

    @Column() @IsNotEmpty()
    updated_at: string;

    @ManyToOne(type => business, business => business.product)
    business_delivery_id: business;

    @ManyToOne(type => product_category, product_category => product_category.product)
    product_category_id: product_category;

    @OneToMany(type => order_line, order_line => order_line.product)
    order_line: order_line[];
}
