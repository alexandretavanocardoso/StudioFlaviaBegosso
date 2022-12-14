import { createRouter, createWebHistory } from 'vue-router'

import GalleryComponent from '@/components/studio-components/gallery/Gallery.vue'
import ContactComponent from '@/components/studio-components/contact/Contact.vue'
import AllWorksComponent from '@/components/studio-components/all-works/AllWorks.vue'
import AboutMeComponent from '@/components/studio-components/about-me/AboutMe.vue'
import BlogComponent from '@/components/studio-components/blog/Blog.vue'
import QuestionsFrequentComponent from '@/components/studio-components/questions-frequents/Questions-frequents.vue'
import HomeComponent from '@/view/Home.vue'

const routes = [
    {
        path: "/",
        component: HomeComponent
    },
    {
        path: "/galeria",
        component: GalleryComponent
    },
    {
        path: "/contato",
        component: ContactComponent
    },
    {
        path: "/serviços",
        component: AllWorksComponent
    },
    {
        path: "/sobre",
        component: AboutMeComponent
    },
    {
        path: "/blog",
        component: BlogComponent
    },
    {
        path: "/perguntas-frequentes",
        component: QuestionsFrequentComponent
    }
]

const router = createRouter({
    history: createWebHistory(),
    routes: routes
})

export default router