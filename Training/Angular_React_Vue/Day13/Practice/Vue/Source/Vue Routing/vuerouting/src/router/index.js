import {createRouter,createWebHistory} from 'vue-router'

import HelloWorld from '../components/HelloWorld.vue'
import PracticeComponent from '../components/PracticeComponent.vue'

const routes = [
    {path:'/helloworld',name:'HelloWorld',component:HelloWorld},
    {path:'/practice', name:'Practice', component:PracticeComponent}
]

const router = createRouter({
    history:createWebHistory(),
    routes
} )

export default router;