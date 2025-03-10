import { IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity, OneToMany, PrimaryGeneratedColumn } from "typeorm";
import { product } from "./product";

@Entity()
export class product_category {

    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty() @MaxLength(100)
    name: string;

    @Column() @IsNotEmpty() @MaxLength(250)
    description: string;

    @Column() @IsNotEmpty() @MaxLength(1)
    state: string;

    @Column() @IsNotEmpty() @MaxLength(10)
    created_at: string;

    @Column() @IsNotEmpty() @MaxLength(10)
    updated_at: string;

    @OneToMany(type => product, Product => Product.product_category)
    product: product[];
}