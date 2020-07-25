import { IOption } from "./option";

export interface IQuestion {
    id?: number;
    name?: string;
    imagePath?: string;
    options?: IOption[];
    answered?: boolean;
    difficulty?: number;
}