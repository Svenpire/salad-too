
export interface Ingredient {
  id: string
  name: string
  type: string
  img: string
  itemGroup: string[]
}

export type Ingredients = Ingredient[]

export interface IngredientType {
  id: string
  name: string
  price: string
  selectType: 'single' | 'multiple'
  img: string
}

export type IngredientTypes = IngredientType[]
