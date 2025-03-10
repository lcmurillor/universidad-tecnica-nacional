import { IsDate, IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity, ManyToOne, PrimaryGeneratedColumn } from "typeorm";
import { user } from "./user";

@Entity()
export class review{
    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty()
    calification: number;

    @Column() @IsNotEmpty()
    comment: string;

    @Column() @IsNotEmpty() @MaxLength(1)
    type: string;

    @Column() @IsNotEmpty()
    created_at: string;

    @Column() @IsNotEmpty()
    updated_at: string;

    @ManyToOne(type => user, User => User.review)
    user: user;
    
    @Column() @IsNotEmpty()
    business_delivery_id: number;
}
