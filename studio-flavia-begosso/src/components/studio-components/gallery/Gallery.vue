<template>
    <div class="mg-top">
        <GalleryListComponent></GalleryListComponent>
    </div>
</template>

<script>
import GalleryListComponent from '@/components/studio-components/_sub-studio-components/litsComponents/galleryList/GalleryList.vue'

export default {
    name: 'GalleryComponent',
    components: {
        GalleryListComponent
    }
}
</script>

<style src="./Gallery.scss" lang="scss" scoped></style>