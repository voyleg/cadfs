FeatureScript 1511;
import(path : "onshape/std/geometry.fs", version : "1511.0");
import(path : "onshape/std/common.fs", version : "1511.0");
const mm = millimeter;
const VERTEX = EntityType.VERTEX;
const EDGE = EntityType.EDGE;
const FACE = EntityType.FACE;
const BODY = EntityType.BODY;
function v(x, y){return vector(x, y);}
function OD(order){return orderDisambiguation(order);}
function OSD(set){return originalSetDisambiguation(set);}
function TD(topology){return topologyDisambiguation(topology);}
function TDD(query){return trueDependencyDisambiguation(query);}
function sQuery(a, b, c) {return sketchEntityQuery(a, b, c);}

annotation { "Feature Type Name" : "Feature", "Feature Type Description" : "" }
export const myFeature = defineFeature(function(context is Context, id is Id, definition is map)
    precondition{}
    {
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0", {"start": v(-101.6, -6.35) * mm, "end": v(-101.6, -25.4) * mm});
            skLineSegment(sketch, "E1", {"start": v(-101.6, -25.4) * mm, "end": v(0, -25.4) * mm});
            skLineSegment(sketch, "E2", {"start": v(0, -25.4) * mm, "end": v(0, 0) * mm});
            skLineSegment(sketch, "E3", {"start": v(0, 0) * mm, "end": v(-101.6, -6.35) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            cPlane(context, id + "F1", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 3657.6 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F1.planeOp",FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E4", {"start": v(0, 0) * mm, "end": v(0, -15.88) * mm});
            skLineSegment(sketch, "E5", {"start": v(0, -15.88) * mm, "end": v(-31.75, -15.88) * mm});
            skLineSegment(sketch, "E6", {"start": v(-31.75, -15.88) * mm, "end": v(-31.75, -1.98) * mm});
            skLineSegment(sketch, "E7", {"start": v(-31.75, -1.98) * mm, "end": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F0",true);
            var Q1;
            Q1=qSketchRegion(id+"F2",true);
            loft(context, id + "F3", {"sheetProfilesArray" : [{ "sheetProfileEntities" : qUnion([Q0]) }, { "sheetProfileEntities" : qUnion([Q1]) }]});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opLoft","SWEPT_BODY",BODY,{"disambiguationData":[OSD([makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]}),makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E4")}),-1.0]])]})])]});
            transform(context, id + "F4", {"entities" : qUnion([Q0]), "transformType" : TransformType.TRANSLATION_3D, "dx" : 0 * mm, "dy" : 0 * mm, "dz" : 0 * mm, "makeCopy" : true});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opLoft","SWEPT_BODY",BODY,{"disambiguationData":[OSD([makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]}),makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E4")}),-1.0]])]})])]});
            var Q1;
            Q1=makeQuery(id+"F4.opPattern","COPY",BODY,{"derivedFrom":makeQuery(id+"F3.opLoft","SWEPT_BODY",BODY,{"disambiguationData":[OSD([makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]}),makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E4")}),-1.0]])]})])]}),"instanceName":"1"});
            deleteBodies(context, id + "F5", {"entities" : qUnion([Q0, Q1])});
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F0",true);
            var Q1;
            Q1=qSketchRegion(id+"F2",true);
            loft(context, id + "F6", {"sheetProfilesArray" : [{ "sheetProfileEntities" : qUnion([Q0]) }, { "sheetProfileEntities" : qUnion([Q1]) }]});
        }
    });